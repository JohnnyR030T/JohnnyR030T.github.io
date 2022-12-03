using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Management;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SelectQuery Sq = new SelectQuery("Win32_OperatingSystem");
        ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
        ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
        foreach (ManagementObject mo in osDetailsCollection)
        {
            Response.Write("Name : " + mo["name"].ToString() + "<br/>");
            Response.Write("Version : " + mo["version"].ToString() + "<br/>");
            Response.Write("Csname : " + mo["csname"].ToString() + "<br/>");
            Response.Write("Boot Device : " + mo["BootDevice"].ToString() + "<br/>");
            Response.Write("Build Number : " + mo["BuildNumber"].ToString() + "<br/>");
            Response.Write("BuildType : " + mo["BuildType"].ToString() + "<br/>");
            Response.Write("Caption : " + mo["Caption"].ToString() + "<br/>");
            Response.Write("CodeSet : " + mo["CodeSet"].ToString() + "<br/>");
            Response.Write("CountryCode : " + mo["CountryCode"].ToString() + "<br/>");
            Response.Write("CreationClassName : " + mo["CreationClassName"].ToString() + "<br/>");
            Response.Write("CSCreationClassName : " + mo["CSCreationClassName"].ToString() + "<br/>");
            Response.Write("CSDVersion : " + mo["CSDVersion"].ToString() + "<br/>");
            Response.Write("CurrentTimeZone : " + mo["CurrentTimeZone"].ToString() + "<br/>");
            Response.Write("DataExecutionPrevention_Available : " + mo["DataExecutionPrevention_Available"].ToString() + "<br/>");
            Response.Write("DataExecutionPrevention_32BitApplications : " + mo["DataExecutionPrevention_32BitApplications"].ToString() + "<br/>");
            Response.Write("DataExecutionPrevention_Drivers : " + mo["DataExecutionPrevention_Drivers"].ToString() + "<br/>");
            Response.Write("DataExecutionPrevention_SupportPolicy : " + mo["DataExecutionPrevention_SupportPolicy"].ToString() + "<br/>");
            Response.Write("Debug : " + mo["Debug"].ToString() + "<br/>");
            Response.Write("Description : " + mo["Description"].ToString() + "<br/>");
            Response.Write("Distributed : " + mo["Distributed"].ToString() + "<br/>");
            Response.Write("EncryptionLevel : " + mo["EncryptionLevel"].ToString() + "<br/>");
            Response.Write("ForegroundApplicationBoost : " + mo["ForegroundApplicationBoost"].ToString() + "<br/>");
            Response.Write("FreePhysicalMemory : " + mo["FreePhysicalMemory"].ToString() + "<br/>");
            Response.Write("FreeSpaceInPagingFiles : " + mo["FreeSpaceInPagingFiles"].ToString() + "<br/>");
            Response.Write("FreeVirtualMemory : " + mo["FreeVirtualMemory"].ToString() + "<br/>");
            Response.Write("InstallDate : " + mo["InstallDate"].ToString() + "<br/>");
            Response.Write("LastBootUpTime : " + mo["LastBootUpTime"].ToString() + "<br/>");
            Response.Write("LocalDateTime : " + mo["LocalDateTime"].ToString() + "<br/>");
            Response.Write("Locale : " + mo["Locale"].ToString() + "<br/>");
            Response.Write("Manufacturer : " + mo["Manufacturer"].ToString() + "<br/>");
            Response.Write("MaxNumberOfProcesses : " + mo["MaxNumberOfProcesses"].ToString() + "<br/>");
            Response.Write("MaxProcessMemorySize : " + mo["MaxProcessMemorySize"].ToString() + "<br/>");
            Response.Write("NumberOfProcesses : " + mo["NumberOfProcesses"].ToString() + "<br/>");
            Response.Write("NumberOfUsers : " + mo["NumberOfUsers"].ToString() + "<br/>");
            Response.Write("OperatingSystemSKU : " + mo["OperatingSystemSKU"].ToString() + "<br/>");
            Response.Write("Organization : " + mo["Organization"].ToString() + "<br/>");
            Response.Write("OSArchitecture : " + mo["OSArchitecture"].ToString() + "<br/>");
            Response.Write("OSLanguage : " + mo["OSLanguage"].ToString() + "<br/>");
            Response.Write("OSType : " + mo["OSType"].ToString() + "<br/>");
            Response.Write("PAEEnabled : " + mo["PAEEnabled"].ToString() + "<br/>");
            Response.Write("Primary : " + mo["Primary"].ToString() + "<br/>");
            Response.Write("ProductType : " + mo["ProductType"].ToString() + "<br/>");
            Response.Write("RegisteredUser : " + mo["RegisteredUser"].ToString() + "<br/>");
            Response.Write("SerialNumber : " + mo["SerialNumber"].ToString() + "<br/>");
            Response.Write("ServicePackMajorVersion : " + mo["ServicePackMajorVersion"].ToString() + "<br/>");
            Response.Write("ServicePackMinorVersion : " + mo["ServicePackMinorVersion"].ToString() + "<br/>");
            Response.Write("SizeStoredInPagingFiles : " + mo["SizeStoredInPagingFiles"].ToString() + "<br/>");
            Response.Write("Status : " + mo["Status"].ToString() + "<br/>");
            Response.Write("SuiteMask : " + mo["SuiteMask"].ToString() + "<br/>");
            Response.Write("SystemDevice : " + mo["SystemDevice"].ToString() + "<br/>");
            Response.Write("SystemDirectory : " + mo["SystemDirectory"].ToString() + "<br/>");
            Response.Write("SystemDrive : " + mo["SystemDrive"].ToString() + "<br/>");
            Response.Write("TotalVirtualMemorySize : " + mo["TotalVirtualMemorySize"].ToString() + "<br/>");
            Response.Write("TotalVisibleMemorySize : " + mo["TotalVisibleMemorySize"].ToString() + "<br/>");
            Response.Write("Version : " + mo["Version"].ToString() + "<br/>");
            Response.Write("WindowsDirectory : " + mo["WindowsDirectory"].ToString() + "<br/>");
        }
    }
}