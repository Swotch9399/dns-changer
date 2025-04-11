# DNSChanger

DNSChanger is a Windows Forms application designed to simplify the process of managing DNS settings and interacting with network configurations. The tool includes various features, such as changing DNS servers, resetting DNS to default settings, testing network connectivity with `ping`, and integrating with the GoodbyeDPI tool to bypass DPI-based censorship.

---

## Features

### 1. **Quick Connect & Disconnect**
- **Status**  
  Displays the current connection status (e.g., Connected / Disconnected). This helps users track whether they are connected to the network and whether DNS settings and GoodbyeDPI are active.

- **Connect**  
  Applies the selected DNS settings and starts GoodbyeDPI. This quickly activates your network with the desired DNS settings and bypasses DPI-based censorship.

- **Disconnect**  
  Resets DNS settings to default (DHCP) and stops GoodbyeDPI. This immediately disconnects from the network and resets DNS settings.

#### Usage:
1. **Quick Connect**  
   To instantly apply DNS settings and connect, click the **Quick Connect** button. This will:
   - Apply the selected DNS settings.
   - Start GoodbyeDPI to bypass DPI-based censorship.

2. **Quick Disconnect**  
   To disconnect and reset settings, click the **Quick Disconnect** button. This will:
   - Reset DNS settings to default (using DHCP).
   - Stop any active GoodbyeDPI process.

### 2. **Change DNS Settings**
- **Primary and Alternate DNS Configuration**  
  Allows users to specify and set primary (preferred) and secondary (alternate) DNS servers for their selected network interface.
  
- **Supported Network Interfaces**
  - Ethernet
  - Wi-Fi
  
- **Auto Network Interface Detection**  
  Automatically detects the active network interface (Ethernet or Wi-Fi) and sets DNS settings accordingly.

#### Usage:
1. Select the network interface (Ethernet or Wi-Fi) or let the tool auto-detect it.
2. Enter the preferred and alternate DNS addresses.
3. Click the `Change DNS` button.

---

### 3. **Reset DNS to Default**
- **Reset to DHCP**  
  Resets the DNS settings of the selected network interface to obtain DNS settings automatically using DHCP.

- **Auto Network Interface Detection**  
  Automatically detects the active network interface for resetting.

#### Usage:
1. Select the network interface or let the tool auto-detect it.
2. Click the `Reset DNS` button.

---

### 4. **Ping Utility**
- **Test Network Connectivity**  
  Send a `ping` to an IP address or domain name to test connectivity and measure latency. Provides detailed results, including round-trip time, TTL, and response status.

#### Usage:
1. Enter a valid IP address or domain name in the `Ping` field.
2. Click the `Ping` button to execute the test.

---

### 5. **GoodbyeDPI Integration**
- **Download and Launch GoodbyeDPI**  
  Automates the download, extraction, and execution of the GoodbyeDPI tool, a utility to bypass DPI-based censorship. Users can specify custom arguments to configure GoodbyeDPI behavior.

- **Stop GoodbyeDPI**  
  Stops all running GoodbyeDPI processes.

- **Remove GoodbyeDPI**  
  Uninstalls GoodbyeDPI and deletes all associated files, including temporary folders.

#### Usage:
1. Enter the desired command-line arguments for GoodbyeDPI in the `Arguments` field.
2. Click `Start GDPI` to launch the tool.
3. To stop GoodbyeDPI, click `Stop GDPI`.
4. To delete GoodbyeDPI, click `Delete GDPI`.

---

### 6. **GoodbyeDPI Windows Service Setup**
- **Service Install GDPI (Install GoodbyeDPI as a Windows Service)**  
  GoodbyeDPI can now be installed as a Windows service. This option allows GoodbyeDPI to automatically start every time Windows boots and continue bypassing DPI-based censorship on network connections.

- **Service Delete GDPI (Remove GoodbyeDPI Windows Service)**  
  After installing GoodbyeDPI as a Windows service, you can use this option to remove the service. This will stop GoodbyeDPI from running as a service.

#### Usage:
1. Click on **Service Install GDPI** to install GoodbyeDPI as a Windows service.
2. Click **Service Delete GDPI** to remove the GoodbyeDPI Windows service.

---

### 7. **DNS Cache Clear**
- **DNS Cache Clear (Clear DNS Cache)**  
  Clears the DNS cache to ensure that changes take effect immediately. This helps to resolve network connectivity issues that may be caused by old DNS records.

#### Usage:
1. Click on the **DNS Cache Clear** button to clear the DNS cache.

---

### 8. **Remember User Inputs**
- **Save and Restore User Inputs (Remember User Inputs)**  
  DNSChanger saves user-entered DNS settings and GoodbyeDPI configurations. This allows users to restore their previous settings after closing and reopening the application.

#### Usage:
1. Enable the **Remember Settings** checkbox.

---

### 9. **System Tray Integration**
- **System Tray Icon**  
  DNSChanger minimizes to the system tray for easy access. Right-click the tray icon for quick access to the following features:
  - **Check for Updates**: Check for new versions of DNSChanger.
  - **Show/Hide**: Minimize or restore the application window.
  - **Quick Connect**: Automatically connect to the active network interface with pre-configured DNS settings.
  - **Quick Disconnect**: Disconnect from the network interface quickly.
  - **Exit**: Close the application completely.

---

### 10. Run as Administrator Check
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
