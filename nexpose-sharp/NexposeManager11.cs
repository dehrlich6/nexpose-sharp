using System;
using System.Xml;

namespace nexposesharp
{
	public class NexposeManager11 : IDisposable
	{
		private NexposeSession _session;
		
		public NexposeManager11 (NexposeSession session)
		{
			if (!session.IsAuthenticated)
				throw new Exception("Trying to create manager from unauthenticated session. Please authenticate.");
			
			_session = session;
		}
		
		
		public void Dispose()
		{
			_session.Logout();
		}
		
		public XmlDocument GetSiteListing()
		{
			string cmd = "<SiteListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetSiteConfig(string siteID)
		{
			string cmd = "<SiteConfigRequest session-id=\"" + _session.SessionID + "\" site-id=\"" + siteID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument SaveOrUpdateSite(XmlNode site)
		{
			string cmd = "<SiteSaveRequest session-id=\"" + _session.SessionID + "\" >";
			
			cmd = cmd + site.OuterXml;
			
			cmd = cmd + "</SiteSaveRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument DeleteSite(string siteID)
		{
			string cmd = "<SiteDeleteRequest session-id=\"" + _session.SessionID + "\" site-id=\"" + siteID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument ScanSite(string siteID)
		{
			string cmd = "<SiteScanRequest session-id=\"" + _session.SessionID + "\" site-id=\"" + siteID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetSiteScanHistory(string siteID)
		{
			string cmd = "<SiteScanHistoryRequest session-id=\"" + _session.SessionID + "\" site-id=\"" + siteID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetSiteDeviceListing(string siteID)
		{
			string cmd = "<SiteDeviceListingRequest session-id=\"" + _session.SessionID + "\" site-id=\"" + siteID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
//		public XmlDocument ScanSiteDevices(XmlNode devices)
//		{
////			string response = new XmlDocument();
////			
////			XmlDocument doc = new XmlDocument();
////			doc.LoadXml(response);
////			
////			return doc;
//		}
		
		public XmlDocument DeleteDevice(string deviceID)
		{
			string cmd = "<DeviceDeleteRequest session-id=\"" + _session.SessionID + "\" device-id=\"" + deviceID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetAssetGroupListing()
		{
			string cmd = "<AssetGroupListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetAssetGroupConfig(string assetGroupID)
		{
			string cmd = "<AssetGroupConfigRequest session-id=\"" + _session.SessionID + "\" group-id=\"" + assetGroupID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument SaveOrUpdateAssetGroup(XmlNode assetGroup)
		{
			string cmd = "<AssetGroupSaveRequest session-id=\"" +_session.SessionID + "\">";
			
			cmd = cmd + assetGroup.OuterXml;
			
			cmd = cmd + "</AssetGroupSaveRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument DeleteAssetGroup(string groupID)
		{
			string cmd = "<AssetGroupDeleteRequest session-id=\"" + _session.SessionID + "\" group-id=\"" + groupID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetScanEngineListing()
		{
			string cmd = "<EngineListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetScanEngineActivity(string engineID)
		{
			string cmd = "<EngineActivityRequest session-id=\"" + _session.SessionID + "\" engine-id=\"" + engineID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetAllScanActivities()
		{
			
			string cmd = "<ScanActivityRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument PauseScan(string scanID)
		{
			string cmd = "<ScanPauseRequest session-id=\"" + _session.SessionID + "\" scan-id=\"" + scanID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument ResumeScan(string scanID)
		{
			string cmd = "<ScanResumeRequest session-id=\"" + _session.SessionID + "\" scan-id=\"" + scanID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument StopScan(string scanID)
		{
			string cmd = "<ScanStopRequest session-id=\"" + _session.SessionID + "\" scan-id=\"" + scanID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetScanStatus(string scanID)
		{
			string cmd = "<ScanStatusRequest session-id=\"" + _session.SessionID + "\" scan-id=\"" + scanID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetScanStatistics(string scanID)
		{
			string cmd = "<ScanStatisticsRequest session-id=\"" + _session.SessionID + "\" scan-id=\"" + scanID + "\" />";
			string response = _session.ExecuteCommand(cmd);
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetVulnerabilityListing()
		{
			string cmd = "<VulnerabilityListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetVulnerabilityDetails(string vulnerabilityID)
		{
			string cmd = "<VulnerabilityDetailsRequest session-id=\"" + _session.SessionID + "\" vuln-id=\"" + vulnerabilityID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetReportTemplateListing()
		{
			string cmd = "<ReportListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetReportTemplateConfig(string reportTemplateID)
		{
			string cmd = "<ReportTemplateConfigRequest session-id=\"" + _session.SessionID + "\" template-id=\"" + reportTemplateID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument SaveOrUpdateReportTemplate(XmlNode reportTemplate)
		{
			string cmd = "<ReportTemplateSaveRequest session-id=\"" + _session.SessionID + "\">";
			
			cmd = cmd + reportTemplate.OuterXml;
			cmd = cmd + "</ReportTemplateSaveRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetReportListing()
		{
			string cmd = "<ReportListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetReportHistory(string reportConfigID)
		{
			string cmd = "<ReportHistoryRequest session-id=\"" + _session.SessionID + "\" report-id=\"" + reportConfigID +  "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetReportConfig(string reportConfigID)
		{
			string cmd = "<ReportConfigRequest session-id=\"" + _session.SessionID + "\" reportcfg-id=\"" + reportConfigID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument SaveOrUpdateReport(XmlNode report, bool generateNow)
		{
			string cmd = "<ReportSaveRequest session-id=\"" + _session.SessionID + "\" generate-now=\"" + (generateNow ? "1" : "0") + "\"  >";
			
			cmd = cmd + report.OuterXml;
			cmd = cmd + "</ReportSaveRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GenerateReport(string reportID)
		{
			string cmd = "<ReportGenerateRequest session-id=\"" + _session.SessionID + "\" report-id=\"" + reportID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument DeleteReport(string reportID)
		{
			string cmd = "<DeleteReportRequest session-id=\"" + _session.SessionID + "\" report-id=\"" + reportID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public string GenerateAdHocReport(XmlNode adHocReportConfig)
		{
			string cmd = "<ReportAdhocGenerateRequest session-id=\"" + _session.SessionID + "\" >";
			
			cmd = cmd + adHocReportConfig.OuterXml;
			
			cmd = cmd + "</ReportAdhocGenerateRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			return response;
		}
		
		public XmlDocument GetUserListing()
		{
			string cmd = "<UserListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetUserAuthenticatorListing()
		{
			string cmd = "<UserAuthenticatorListingRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetUserConfig(string userID)
		{
			string cmd = "<UserConfigRequest session-id=\"" + _session.SessionID + "\" id=\"" + userID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument SaveOrUpdateUser(XmlNode user)
		{
			string cmd = "<UserSaveRequest session-id=\"" + _session.SessionID + "\" >";
			cmd = cmd + user.OuterXml;
			cmd = cmd + "</UserSaveRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument DeleteUser(string userID)
		{
			string cmd = "<UserDeleteRequest session-id=\"" + _session.SessionID + "\" id=\"" + userID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument ExecuteConsoleCommand(XmlNode command)
		{
			string cmd = "<ConsoleCommandRequest session-id=\"" + _session.SessionID + "\" >";
			cmd = cmd + command.OuterXml;
			cmd = "</ConsoleCommandRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument GetSystemInformation()
		{
			string cmd = "<SystemInformationRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument StartUpdate()
		{
			string cmd = "<StartUpdateRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument Restart()
		{
			string cmd = "<RestartRequest session-id=\"" + _session.SessionID + "\" />";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
		
		public XmlDocument SendLog(XmlNode transport)
		{
			string cmd = "<SendLogRequest session-id=\"" + _session.SessionID + "\" >";
			
			cmd = cmd + transport.OuterXml;
			cmd = cmd + "</SendLogRequest>";
			
			string response = _session.ExecuteCommand(cmd);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(response);
			
			return doc;
		}
	}
}

