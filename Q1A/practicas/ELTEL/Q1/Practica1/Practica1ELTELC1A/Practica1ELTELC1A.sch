EESchema Schematic File Version 4
EELAYER 30 0
EELAYER END
$Descr User 5315 4331
encoding utf-8
Sheet 1 1
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L pspice:VSOURCE 5V
U 1 1 5F720FD8
P 1450 1900
F 0 "5V" H 1678 1946 50  0000 L CNN
F 1 "FA" H 1678 1855 50  0000 L CNN
F 2 "" H 1450 1900 50  0001 C CNN
F 3 "~" H 1450 1900 50  0001 C CNN
	1    1450 1900
	1    0    0    -1  
$EndComp
$Comp
L Device:Voltmeter_DC 5V
U 1 1 5F7223EA
P 3200 1850
F 0 "5V" H 3047 1759 50  0000 R CNN
F 1 "MD" H 3047 1850 50  0000 R CNN
F 2 "" V 3200 1950 50  0001 C CNN
F 3 "10MOhm" H 3047 1941 50  0000 R CNN
	1    3200 1850
	-1   0    0    1   
$EndComp
Wire Wire Line
	1450 1600 3200 1600
Wire Wire Line
	3200 1600 3200 1650
Wire Wire Line
	3200 2050 3200 2200
Wire Wire Line
	3200 2200 1450 2200
$EndSCHEMATC
