# DNSChanger

DNSChanger is a Windows Forms application designed to simplify the process of managing DNS settings and interacting with network configurations. The tool includes various features, such as changing DNS servers, resetting DNS to default settings, testing network connectivity with `ping`, and integrating with the GoodbyeDPI tool to bypass DPI-based censorship.

---

## Features

### 1. Change DNS Settings
- **Primary and Alternate DNS Configuration**  
  Allows users to specify and set primary (preferred) and secondary (alternate) DNS servers for their selected network interface.
- **Supported Network Interfaces**  
  - Ethernet
  - Wi-Fi  

**Usage:**  
1. Select the network interface (Ethernet or Wi-Fi).  
2. Enter the preferred and alternate DNS addresses in the respective fields.  
3. Click the `Change DNS` button.

---

### 2. Reset DNS to Default
- **Reset to DHCP**  
  Resets the DNS settings of the selected network interface to obtain DNS settings automatically using DHCP.

**Usage:**  
1. Select the network interface (Ethernet or Wi-Fi).  
2. Click the `Reset DNS` button.

---

### 3. Ping Utility
- **Test Network Connectivity**  
  Send a `ping` to an IP address or domain name to test connectivity and measure latency. Provides detailed results, including round-trip time, TTL, and response status.

**Usage:**  
1. Enter a valid IP address or domain name in the `Ping` field.  
2. Click the `Ping` button to execute the test.

---

### 4. GoodbyeDPI Integration
- **Download and Launch GoodbyeDPI**  
  Automates the download, extraction, and execution of the GoodbyeDPI tool, a utility to bypass DPI-based censorship. Users can specify custom arguments to configure GoodbyeDPI behavior.
- **Stop GoodbyeDPI**  
  Stops all running GoodbyeDPI processes.

**Usage:**  
1. Enter the desired command-line arguments for GoodbyeDPI in the `Arguments` field.  
2. Click `Start GoodbyeDPI` to launch the tool.  
3. To stop GoodbyeDPI, click `Stop GoodbyeDPI`.

---

## Prerequisites
- **Administrator Privileges**  
  The application must be run as an administrator to modify network configurations or execute GoodbyeDPI. If not started with elevated privileges, the application will display a warning and close.
- **.NET Framework**  
  Requires .NET Framework 4.7.2 or later.

---

## How It Works
- **Changing DNS:**  
  Uses the `netsh` command-line utility to update DNS settings for the selected network interface.
- **Resetting DNS:**  
  Configures the DNS settings to "Obtain DNS server address automatically" using `netsh`.
- **GoodbyeDPI:**  
  Downloads GoodbyeDPI from the official GitHub repository, extracts the files, and launches the executable with the specified arguments.
- **Ping:**  
  Utilizes the `System.Net.NetworkInformation.Ping` class to send ICMP echo requests and display the results.

---

## Installation
1. Download the executable and source files from the repository.
2. Launch the application with administrator privileges.

---

## Troubleshooting
- **"The application was not run as administrator"**  
  Ensure that the application is launched with elevated permissions. Right-click the executable and select "Run as Administrator."
- **"GoodbyeDPI executable not found!"**  
  Verify that the GoodbyeDPI download process was successful, or manually download and place the executable in the required path.

---

## License
This tool is provided as-is. It integrates the open-source [GoodbyeDPI](https://github.com/ValdikSS/GoodbyeDPI) utility. Refer to the GoodbyeDPI repository for licensing information.

---

## Disclaimer
The use of this tool and GoodbyeDPI may be subject to local laws and regulations. The developer is not responsible for any misuse or legal implications arising from its usage.

---

## Contact
For any questions or feedback, feel free to open an issue in the repository.
