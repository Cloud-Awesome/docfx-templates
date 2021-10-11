# Bookable Resource Booking

Represents the line details of a resource booking. 

| Setting | Value | 
|---|---|
| Collection Name | Bookable Resource Bookings | 
| Logical Name | bookableresourcebooking | 
| Primary attribute name | bookableresourcebookingid | 
| Object Type Code | 1145 | 
| Is custom table | No | 



---


## Attributes

| Display Name | Logical Name | Datatype | Description | 
|---|---|---|---|
| Base Travel Duration | msdyn_basetravelduration | Integer | The Base travel duration indicates the travel time without traffic | 
| Booking Setup Metadata | msdyn_bookingsetupmetadataid | Lookup | A unique identifier for the booking setup metadata that is associated with a bookable resource booking. | 
| Version Number | versionnumber | BigInt | Version Number | 
| Created On | createdon | DateTime | Date and time when the record was created. | 
| Header | header | Lookup | Shows the reference to the booking header record that represents the summary of bookings. | 
| (Deprecated) Traversed Path | traversedpath | String | A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur. | 
| Modified On | modifiedon | DateTime | Date and time when the record was modified. |  
| Created By (Delegate) | createdonbehalfby | Lookup | Unique identifier of the delegate user who created the record. | 
| End Time | endtime | DateTime | Enter the end date and time of the booking. | 
| Booking Method | msdyn_bookingmethod | Picklist | Shows the method used to create this booking. | 
| Record Created On | overriddencreatedon | DateTime | Date and time that the record was migrated. | 
| (Deprecated) Stage Id | stageid | Uniqueidentifier | Contains the id of the stage where the entity is located. | 
| Cascade Crew Changes | msdyn_cascadecrewchanges | Boolean | Defines whether changing any of the following fields (Start Time, End Time, Status) should cascade the changes to other bookings on this requirement that have the same start and end time. | 
| Modified By (Delegate) | modifiedonbehalfby | Lookup | Unique identifier of the delegate user who modified the record. | 
| Booking Status | bookingstatus | Lookup | Select the status of the booking. | 
| Owning Team | owningteam | Lookup | Unique identifier for the team that owns the record. | 
| Miles Traveled | msdyn_milestraveled | Double | In this field you can enter the total miles the resource drove to the job site | 
| Status | statecode | State | Status of the Bookable Resource Booking | 
| Time Zone Rule Version Number | timezoneruleversionnumber | Integer | For internal use only. | 
| Appointment Booking | msdyn_appointmentbookingid | Lookup | Unique identifier for Appointment associated with Bookable Resource Booking. | 
| ExchangeRate | exchangerate | Decimal | Exchange rate for the currency associated with the bookableresourcebooking with respect to the base currency. | 
| Requirement Group Set | msdyn_requirementgroupset | String | Requirement Group Set | 
| Resource | resource | Lookup | Shows the resource that is booked. | 
| Bookable Resource Booking | bookableresourcebookingid | Uniqueidentifier | Unique identifier of the resource booking. | 
| Estimated Arrival Time | msdyn_estimatedarrivaltime | DateTime | Estimated Arrival Time | 
| Capacity | msdyn_effort | Decimal | Capacity that needs to take from resource capacity | 
| UTC Conversion Time Zone Code | utcconversiontimezonecode | Integer | Time zone code that was in use when the record was created. | 
| Accept Cascade Crew Changes | msdyn_acceptcascadecrewchanges | Boolean | Defines whether this booking accepts changes propagated as cascading changes | 
| Owner | ownerid | Owner | Owner Id | 
| Start Time | starttime | DateTime | Enter the start date and time of the booking. | 
| Import Sequence Number | importsequencenumber | Integer | Sequence number of the import that created this record. | 
| Duration | duration | Integer | Enter the duration of the booking. | 
| Resource Requirement | msdyn_resourcerequirement | Lookup | Resource Requirement | 
| Requirement Group | msdyn_requirementgroupid | Lookup | Requirement Group | 
| Process Id | processid | Uniqueidentifier | Contains the id of the process associated with the entity. | 
| Estimated Travel Duration | msdyn_estimatedtravelduration | Integer | Estimated Travel Duration | 
| Actual Arrival Time | msdyn_actualarrivaltime | DateTime | Shows the time that work started. | 
| Actual Travel Duration | msdyn_actualtravelduration | Integer | Shows the total travel duration. Calculated based on the difference between the Bookable Resource Booking's start time and actual arrival time. | 
| Currency | transactioncurrencyid | Lookup | Exchange rate for the currency associated with the BookableResourceBooking with respect to the base currency. | 
| Created By | createdby | Lookup | Unique identifier of the user who created the record. | 
| Modified By | modifiedby | Lookup | Unique identifier of the user who modified the record. | 
| Travel Time Calculation | msdyn_traveltimecalculationtype | Picklist | Travel Time Calculation | 
| Booking Type | bookingtype | Picklist | Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed. | 
| Internal Flags | msdyn_ursinternalflags | Memo | For internal use only. | 
| Owning User | owninguser | Lookup | Unique identifier for the user that owns the record. | 
| Work Location | msdyn_worklocation | Picklist |  | 
| Owning Business Unit | owningbusinessunit | Lookup | Unique identifier for the business unit that owns the record | 
| Latitude | msdyn_latitude | Double |  | 
| Name | name | String | Type a name for the booking. | 
| Status Reason | statuscode | Status | Reason for the status of the Bookable Resource Booking | 
| Longitude | msdyn_longitude | Double |  | 
| Allow Overlapping | msdyn_allowoverlapping | Boolean | Allow the time of this booking to be displayed on the schedule assistant as available. | 
| Time Group Detail Selected | msdyn_timegroupdetailselected | Lookup |  | 
| Resource Group | msdyn_resourcegroup | Lookup | Unique identifier for Resource associated with Resource Booking | 
| Service Activity | msdyn_serviceappointment | Lookup | Unique identifier for Service Appointment associated with Resource Booking. | 


 

## Relationships

### One to many relationships

| Related entity | Foreign key | Schema name | 
|---|---|---|
| activitypointer | regardingobjectid | bookableresourcebooking_ActivityPointers | 
| syncerror | regardingobjectid | BookableResourceBooking_SyncErrors | 
| duplicaterecord | duplicaterecordid | bookableresourcebooking_DuplicateMatchingRecord | 
| duplicaterecord | baserecordid | bookableresourcebooking_DuplicateBaseRecord | 
| asyncoperation | regardingobjectid | bookableresourcebooking_AsyncOperations | 
| mailboxtrackingfolder | regardingobjectid | bookableresourcebooking_MailboxTrackingFolders | 
| userentityinstancedata | objectid | bookableresourcebooking_UserEntityInstanceDatas | 
| processsession | regardingobjectid | bookableresourcebooking_ProcessSession | 
| bulkdeletefailure | regardingobjectid | bookableresourcebooking_BulkDeleteFailures | 
| principalobjectattributeaccess | objectid | bookableresourcebooking_PrincipalObjectAttributeAccess | 
| appointment | regardingobjectid | bookableresourcebooking_Appointments | 
| email | regardingobjectid | bookableresourcebooking_Emails | 
| fax | regardingobjectid | bookableresourcebooking_Faxes | 
| letter | regardingobjectid | bookableresourcebooking_Letters | 
| phonecall | regardingobjectid | bookableresourcebooking_PhoneCalls | 
| task | regardingobjectid | bookableresourcebooking_Tasks | 
| recurringappointmentmaster | regardingobjectid | bookableresourcebooking_RecurringAppointmentMasters | 
| socialactivity | regardingobjectid | bookableresourcebooking_SocialActivities | 
| annotation | objectid | bookableresourcebooking_Annotations | 
| bulkoperation | regardingobjectid | bookableresourcebooking_BulkOperations | 
| campaignactivity | regardingobjectid | bookableresourcebooking_CampaignActivities | 
| campaignresponse | regardingobjectid | bookableresourcebooking_CampaignResponses | 
| incidentresolution | regardingobjectid | bookableresourcebooking_IncidentResolutions | 
| serviceappointment | regardingobjectid | bookableresourcebooking_ServiceAppointments | 
| opportunityclose | regardingobjectid | bookableresourcebooking_OpportunityCloses | 
| orderclose | regardingobjectid | bookableresourcebooking_OrderCloses | 
| quoteclose | regardingobjectid | bookableresourcebooking_QuoteCloses | 
| msfp_alert | regardingobjectid | bookableresourcebooking_msfp_alerts | 
| msfp_surveyinvite | regardingobjectid | bookableresourcebooking_msfp_surveyinvites | 
| msfp_surveyresponse | regardingobjectid | bookableresourcebooking_msfp_surveyresponses | 
| msdyn_bookingalert | regardingobjectid | bookableresourcebooking_msdyn_bookingalerts | 
| adx_alertsubscription | regardingobjectid | bookableresourcebooking_adx_alertsubscriptions | 
| adx_inviteredemption | regardingobjectid | bookableresourcebooking_adx_inviteredemptions | 
| adx_portalcomment | regardingobjectid | bookableresourcebooking_adx_portalcomments | 
 

### Many to relationships

| Primary entity | Foreign key | Schema name | 
|---|---|---|
| activitypointer | regardingobjectid | bookableresourcebooking_ActivityPointers | 
| syncerror | regardingobjectid | BookableResourceBooking_SyncErrors | 
| duplicaterecord | duplicaterecordid | bookableresourcebooking_DuplicateMatchingRecord | 
| duplicaterecord | baserecordid | bookableresourcebooking_DuplicateBaseRecord | 
| asyncoperation | regardingobjectid | bookableresourcebooking_AsyncOperations | 
| mailboxtrackingfolder | regardingobjectid | bookableresourcebooking_MailboxTrackingFolders | 
| userentityinstancedata | objectid | bookableresourcebooking_UserEntityInstanceDatas | 
| processsession | regardingobjectid | bookableresourcebooking_ProcessSession | 
| bulkdeletefailure | regardingobjectid | bookableresourcebooking_BulkDeleteFailures | 
| principalobjectattributeaccess | objectid | bookableresourcebooking_PrincipalObjectAttributeAccess | 
| appointment | regardingobjectid | bookableresourcebooking_Appointments | 
| email | regardingobjectid | bookableresourcebooking_Emails | 
| fax | regardingobjectid | bookableresourcebooking_Faxes | 
| letter | regardingobjectid | bookableresourcebooking_Letters | 
| phonecall | regardingobjectid | bookableresourcebooking_PhoneCalls | 
| task | regardingobjectid | bookableresourcebooking_Tasks | 
| recurringappointmentmaster | regardingobjectid | bookableresourcebooking_RecurringAppointmentMasters | 
| socialactivity | regardingobjectid | bookableresourcebooking_SocialActivities | 
| annotation | objectid | bookableresourcebooking_Annotations | 
| bulkoperation | regardingobjectid | bookableresourcebooking_BulkOperations | 
| campaignactivity | regardingobjectid | bookableresourcebooking_CampaignActivities | 
| campaignresponse | regardingobjectid | bookableresourcebooking_CampaignResponses | 
| incidentresolution | regardingobjectid | bookableresourcebooking_IncidentResolutions | 
| serviceappointment | regardingobjectid | bookableresourcebooking_ServiceAppointments | 
| opportunityclose | regardingobjectid | bookableresourcebooking_OpportunityCloses | 
| orderclose | regardingobjectid | bookableresourcebooking_OrderCloses | 
| quoteclose | regardingobjectid | bookableresourcebooking_QuoteCloses | 
| msfp_alert | regardingobjectid | bookableresourcebooking_msfp_alerts | 
| msfp_surveyinvite | regardingobjectid | bookableresourcebooking_msfp_surveyinvites | 
| msfp_surveyresponse | regardingobjectid | bookableresourcebooking_msfp_surveyresponses | 
| msdyn_bookingalert | regardingobjectid | bookableresourcebooking_msdyn_bookingalerts | 
| adx_alertsubscription | regardingobjectid | bookableresourcebooking_adx_alertsubscriptions | 
| adx_inviteredemption | regardingobjectid | bookableresourcebooking_adx_inviteredemptions | 
| adx_portalcomment | regardingobjectid | bookableresourcebooking_adx_portalcomments | 


 

