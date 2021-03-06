﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PushSampleDataToSentinelLogs
{
    public class CEFevent
    {
        public string TenantId { get; set; }
        public string SourceSystem { get; set; }
        public string TimeGenerated { get; set; }
        public string ReceiptTime { get; set; }
        public string DeviceVendor { get; set; }
        public string DeviceProduct { get; set; }
        public string DeviceEventClassID { get; set; }
        public string LogSeverity { get; set; }
        public string OriginalLogSeverity { get; set; }
        public string DeviceAction { get; set; }
        public string SimplifiedDeviceAction { get; set; }
        public string Computer { get; set; }
        public string CommunicationDirection { get; set; }
        public string DeviceFacility { get; set; }
        public string DestinationPort { get; set; }
        public string DestinationIP { get; set; }
        public string DeviceAddress { get; set; }
        public string DeviceName { get; set; }
        public string Message { get; set; }
        public string Protocol { get; set; }
        public string SourcePort { get; set; }
        public string SourceIP { get; set; }
        public string RemoteIP { get; set; }
        public string RemotePort { get; set; }
        public string MaliciousIP { get; set; }
        public string ThreatSeverity { get; set; }
        public string IndicatorThreatType { get; set; }
        public string ThreatDescription { get; set; }
        public string ThreatConfidence { get; set; }
        public string ReportReferenceLink { get; set; }
        public string MaliciousIPLongitude { get; set; }
        public string MaliciousIPLatitude { get; set; }
        public string MaliciousIPCountry { get; set; }
        public string DeviceVersion { get; set; }
        public string Activity { get; set; }
        public string ApplicationProtocol { get; set; }
        public string EventCount { get; set; }
        public string DestinationDnsDomain { get; set; }
        public string DestinationServiceName { get; set; }
        public string DestinationTranslatedAddress { get; set; }
        public string DestinationTranslatedPort { get; set; }
        public string DeviceDnsDomain { get; set; }
        public string DeviceExternalID { get; set; }
        public string DeviceInboundInterface { get; set; }
        public string DeviceNtDomain { get; set; }
        public string DeviceOutboundInterface { get; set; }
        public string DevicePayloadId { get; set; }
        public string ProcessName { get; set; }
        public string DeviceTranslatedAddress { get; set; }
        public string DestinationHostName { get; set; }
        public string DestinationMACAddress { get; set; }
        public string DestinationNTDomain { get; set; }
        public string DestinationProcessId { get; set; }
        public string DestinationUserPrivileges { get; set; }
        public string DestinationProcessName { get; set; }
        public string DeviceTimeZone { get; set; }
        public string DestinationUserID { get; set; }
        public string DestinationUserName { get; set; }
        public string DeviceMacAddress { get; set; }
        public string ProcessID { get; set; }
        public string ExternalID { get; set; }
        public string FileCreateTime { get; set; }
        public string FileHash { get; set; }
        public string FileID { get; set; }
        public string FileModificationTime { get; set; }
        public string FilePath { get; set; }
        public string FilePermission { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string ReceivedBytes { get; set; }
        public string OldFileCreateTime { get; set; }
        public string OldFileHash { get; set; }
        public string OldFileID { get; set; }
        public string OldFileModificationTime { get; set; }
        public string OldFileName { get; set; }
        public string OldFilePath { get; set; }
        public string OldFilePermission { get; set; }
        public string OldFileSize { get; set; }
        public string OldFileType { get; set; }
        public string SentBytes { get; set; }
        public string RequestURL { get; set; }
        public string RequestClientApplication { get; set; }
        public string RequestContext { get; set; }
        public string RequestCookies { get; set; }
        public string RequestMethod { get; set; }
        public  string SourceHostName { get; set; }
        public string SourceMACAddress { get; set; }
        public string SourceNTDomain { get; set; }
        public string SourceDnsDomain { get; set; }
        public  string SourceServiceName { get; set; }
        public string SourceTranslatedAddress { get; set; }
        public string SourceTranslatedPort { get; set; }
        public string SourceProcessId { get; set; }
        public string SourceUserPrivileges { get; set; }
        public string SourceProcessName { get; set; }
        public string SourceUserID { get; set; }
        public string SourceUserName { get; set; }
        public string EventType { get; set; }
        public string DeviceCustomIPv6Address1 { get; set; }
        public string DeviceCustomIPv6Address1Label { get; set; }
        public string DeviceCustomIPv6Address2 { get; set; }
        public string DeviceCustomIPv6Address2Label { get; set; }
        public string DeviceCustomIPv6Address3 { get; set; }
        public string DeviceCustomIPv6Address3Label { get; set; }
        public string DeviceCustomIPv6Address4 { get; set; }
        public string DeviceCustomIPv6Address4Label { get; set; }
        public string DeviceCustomFloatingPoint1 { get; set; }
        public string DeviceCustomFloatingPoint1Label { get; set; }
        public string DeviceCustomFloatingPoint2 { get; set; }
        public string DeviceCustomFloatingPoint2Label { get; set; }
        public string DeviceCustomFloatingPoint3 { get; set; }
        public string DeviceCustomFloatingPoint3Label { get; set; }
        public string DeviceCustomFloatingPoint4 { get; set; }
        public string DeviceCustomFloatingPoint4Label { get; set; }
        public string DeviceCustomNumber1 { get; set; }
        public string DeviceCustomNumber1Label { get; set; }
        public string DeviceCustomNumber2 { get; set; }
        public string DeviceCustomNumber2Label { get; set; }
        public string DeviceCustomNumber3 { get; set; }
        public string DeviceCustomNumber3Label { get; set; }
        public string DeviceCustomString1 { get; set; }
        public string DeviceCustomString1Label { get; set; }
        public string DeviceCustomString2 { get; set; }
        public string DeviceCustomString2Label { get; set; }
        public string DeviceCustomString3 { get; set; }
        public string DeviceCustomString3Label { get; set; }
        public string DeviceCustomString4 { get; set; }
        public string DeviceCustomString4Label { get; set; }
        public string DeviceCustomString5 { get; set; }
        public string DeviceCustomString5Label { get; set; }
        public string DeviceCustomString6 { get; set; }
        public string DeviceCustomString6Label { get; set; }
        public string DeviceCustomDate1 { get; set; }
        public string DeviceCustomDate1Label { get; set; }
        public string DeviceCustomDate2 { get; set; }
        public string DeviceCustomDate2Label { get; set; }
        public string FlexDate1 { get; set; }
        public string FlexDate1Label { get; set; }
        public string FlexNumber1 { get; set; }
        public string FlexNumber1Label { get; set; }
        public string FlexNumber2 { get; set; }
        public string FlexNumber2Label { get; set; }
        public string FlexString1 { get; set; }
        public string FlexString1Label { get; set; }
        public string FlexString2 { get; set; }
        public string FlexString2Label { get; set; }
        public string AdditionalExtensions { get; set; }
        public string StartTime { get; set; }
        public string MyProEndTimeperty { get; set; }
        public string Type { get; set; }
        public string _ResourceId { get; set; }
    }
}














































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































