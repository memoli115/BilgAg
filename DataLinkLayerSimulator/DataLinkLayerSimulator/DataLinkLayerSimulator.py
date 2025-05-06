import struct
import binascii
import random
import time
import matplotlib.pyplot as plt
import numpy as np

def generate_mac_address():
    """Rastgele MAC adresi oluşturur."""
    return ':'.join(f"{random.randint(0, 255):02x}" for _ in range(6))

def crc32(data):
    """CRC-32 hesaplaması yapar."""
    return binascii.crc32(data) & 0xFFFFFFFF

def crc16(data):
    """CRC-16 hesaplaması yapar."""
    crc = 0xFFFF
    poly = 0x1021
    for byte in data:
        for i in range(8):
            bit = (byte >> (7 - i)) & 1
            cbit = (crc >> 15) & 1
            crc <<= 1
            if cbit ^ bit:
                crc ^= poly
            crc &= 0xFFFF
    return crc

def hamming_encode(data):
    """Hamming (7,4) kodlaması uygular."""
    encoded_data = []
    for byte in data:
        d = [(byte >> i) & 1 for i in range(4)]
        p1 = d[0] ^ d[1] ^ d[3]
        p2 = d[0] ^ d[2] ^ d[3]
        p3 = d[1] ^ d[2] ^ d[3]
        encoded_byte = (p1 << 6) | (p2 << 5) | (d[0] << 4) | (p3 << 3) | (d[1] << 2) | (d[2] << 1) | d[3]
        encoded_data.append(encoded_byte)
    return bytes(encoded_data)

def create_ethernet_frame_ieee802_3(src_mac, dst_mac, payload):
    """IEEE 802.3 Ethernet çerçevesi oluşturur."""
    preamble = b'\x55' * 7 + b'\xD5'  # 7 byte preamble + 1 byte SFD
    length = len(payload).to_bytes(2, byteorder='big')
    frame = struct.pack('!6s6s2s', binascii.unhexlify(dst_mac.replace(':', '')),
                                    binascii.unhexlify(src_mac.replace(':', '')),
                                    length)
    frame += payload
    crc = struct.pack('!I', crc32(frame))
    return preamble + frame + crc

def random_bit_bozma(modified_frame,bit_count):
    for _ in range(bit_count):
        error_index = random.randint(0, len(modified_frame) - 1)
        modified_frame[error_index] ^= 0x01
    return modified_frame

def simulate_transmission():
    """IEEE 802.3 Ethernet çerçevesi oluşturup hata kontrol algoritmalarını test eder."""
    src_mac = generate_mac_address()
    dst_mac = generate_mac_address()
    data_sizes = [64, 512, 1500]
    results = []

    for size in data_sizes:
        payload = bytes(random.getrandbits(8) for _ in range(size)) #rastgele veri oluşturma
        frame = create_ethernet_frame_ieee802_3(src_mac, dst_mac, payload) #ethernet frameini oluşturma
        errors_detected = 0
        total_tests = 100

        start_time = time.time()
        crc32_res = crc32(frame)
        crc32_time = time.time() - start_time

        start_time = time.time()
        crc16_res = crc16(frame)
        crc16_time = time.time() - start_time

        start_time = time.time()
        hamming_res = hamming_encode(frame)
        hamming_time = time.time() - start_time

        #algoritmayı 100 defa teste sokuyoruz eğer hatası olursa errors_detected'i '1' artırıyoruz
        for _ in range(total_tests):
            modified_frame = bytearray(frame)
            modified_frame= random_bit_bozma(modified_frame,2)
            if crc32(bytes(modified_frame)) != crc32_res:
                errors_detected += 1
        crc32_accuracy = errors_detected / total_tests

        errors_detected = 0
        #algoritmayı 100 defa teste sokuyoruz eğer hatası olursa errors_detected'i '1' artırıyoruz
        for _ in range(total_tests):
            modified_frame = bytearray(frame)
            modified_frame=random_bit_bozma(modified_frame,2)
            if crc16(bytes(modified_frame)) != crc16_res:
                errors_detected += 1
        crc16_accuracy = errors_detected / total_tests

        errors_detected = 0
        #algoritmayı 100 defa teste sokuyoruz eğer hatası olursa errors_detected'i '1' artırıyoruz
        for _ in range(total_tests):
            modified_frame = bytearray(hamming_res)
            modified_frame=random_bit_bozma(modified_frame,2)
            if hamming_encode(bytes(modified_frame)) != hamming_res:
                errors_detected += 1
        hamming_accuracy = errors_detected / total_tests

        results.append((size, crc32_time, crc16_time, hamming_time, crc32_accuracy, crc16_accuracy, hamming_accuracy))
        print(f"Boyut: {size} byte, CRC-32 Süresi: {crc32_time:.6f} s, Doğruluk: {crc32_accuracy:.2f}, "
              f"CRC-16 Süresi: {crc16_time:.6f} s, Doğruluk: {crc16_accuracy:.2f}, "
              f"Hamming Süresi: {hamming_time:.6f} s, Doğruluk: {hamming_accuracy:.2f}")

    # Verileri parçalara ayır
    sizes, crc32_times, crc16_times, hamming_times, crc32_acc, crc16_acc, hamming_acc = zip(*results) #sonucu parçalara bölmek
    x = np.arange(len(sizes))

    # Performans süreleri için grafik
    plt.figure(figsize=(10, 5))
    plt.bar(x - 0.2, crc32_times, 0.2, label='CRC-32 Süre')
    plt.bar(x, crc16_times, 0.2, label='CRC-16 Süre')
    plt.bar(x + 0.2, hamming_times, 0.2, label='Hamming Süre')
    plt.xlabel("Veri Boyutu (byte)")
    plt.ylabel("İşlem Süresi (saniye)")
    plt.xticks(x, sizes)
    plt.legend()
    plt.title("Hata Algılama Algoritmalarının Performans Süreleri")
    plt.grid(True, linestyle='--', alpha=0.7)
    plt.show()

    # Doğruluk oranları için grafik
    plt.figure(figsize=(10, 5))
    plt.plot(x, crc32_acc, 'ro-', label='CRC-32 Doğruluk')
    plt.plot(x, crc16_acc, 'go-', label='CRC-16 Doğruluk')
    plt.plot(x, hamming_acc, 'bo-', label='Hamming Doğruluk')
    plt.xlabel("Veri Boyutu (byte)")
    plt.ylabel("Doğruluk Oranı")
    plt.xticks(x, sizes)
    plt.legend()
    plt.title("Hata Algılama Algoritmalarının Doğruluk Oranı Karşılaştırması")
    plt.grid(True, linestyle='--', alpha=0.7)
    plt.show()

simulate_transmission()