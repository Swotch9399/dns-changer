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
- **Remove GoodbyeDPI**  
  Uninstalls GoodbyeDPI and deletes all associated files, including temporary folders.

**Usage:**  
1. Enter the desired command-line arguments for GoodbyeDPI in the `Arguments` field.  
2. Click `Start GDPI` to launch the tool.  
3. To stop GoodbyeDPI, click `Stop GDPI`.  
4. To delete GoodbyeDPI, click `Delete GDPI`.

---

### 5. GoodbyeDPI Windows Service Setup
- **Service Install GDPI (Install GoodbyeDPI as a Windows Service)**  
  GoodbyeDPI can now be installed as a Windows service. This option allows GoodbyeDPI to automatically start every time Windows boots and continue bypassing DPI-based censorship on network connections. 

**Usage:**  
1. Click on **Service Install GDPI** to install GoodbyeDPI as a Windows service.  
2. The application will set up GoodbyeDPI as a service, ensuring it starts automatically with Windows.

- **Service Delete GDPI (Remove GoodbyeDPI Windows Service)**  
  After installing GoodbyeDPI as a Windows service, you can use this option to remove the service. This will stop GoodbyeDPI from running as a service.

**Usage:**  
1. Click **Service Delete GDPI** to remove the GoodbyeDPI Windows service.  
2. This will completely remove GoodbyeDPI from the system and prevent it from starting automatically.

---

### 6. DNS Cache Clear
- **DNS Cache Clear (Clear DNS Cache)**  
  DNSChanger now includes the ability to clear the DNS cache. Old DNS records can sometimes cause network connectivity issues, and this feature helps clear the DNS cache to ensure that changes take effect immediately.

**Usage:**  
1. Click on the **DNS Cache Clear** button to clear the DNS cache.  
2. After this process, the DNS cache will be reset, potentially improving network connectivity.

---

### 7. Remember User Inputs
- **Save and Restore User Inputs (Remember User Inputs)**  
  DNSChanger now has the ability to save user-entered DNS settings and GoodbyeDPI configurations. This feature allows users to restore their previous settings after closing and reopening the application.

**Usage:**  
1. Enable the **Remember Settings** check box.

---

### 8. System Tray Integration
- **System Tray Icon**  
  DNSChanger minimizes to the system tray for easy access. Right-click the tray icon for quick access to the following features:
  - **Check for Updates**: Check for new versions of DNSChanger.
  - **Show/Hide**: Minimize or restore the application window.
  - **Exit**: Close the application completely.

---

### 9. Run as Administrator Check
- **Administrator Privileges**  
  The application must be run as an administrator to modify network configurations or execute GoodbyeDPI. If not started with elevated privileges, the application will display a warning and close.

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
- **GoodbyeDPI Service:** 
  It uses the 'sc' command line utility to download and install services.
- **Ping:**  
  Utilizes the `System.Net.NetworkInformation.Ping` class to send ICMP echo requests and display the results.
- **DNS Cache Clear:**
  It uses the 'ipconfig /flushdns' command line utility to flush the DNS cache.

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
- **"GoodbyeDPI removal failed!"**  
  If GoodbyeDPI doesn't uninstall correctly, try closing any running processes and restart the application to ensure the deletion of associated files.

---

## License
This tool is provided as-is under the **MIT License**. See the [LICENSE](LICENSE) file for more information.

### GoodbyeDPI License
The GoodbyeDPI tool is released under the **MIT License**. Please refer to the [GoodbyeDPI GitHub](https://github.com/ValdikSS/GoodbyeDPI) repository for detailed license information.

---

## Disclaimer
The use of this tool and GoodbyeDPI may be subject to local laws and regulations. The developer is not responsible for any misuse or legal implications arising from its usage.

---

## Contact
For any questions or feedback, feel free to open an issue in the repository.
