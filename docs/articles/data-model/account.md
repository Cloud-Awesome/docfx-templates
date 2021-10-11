# Account

Business that represents a customer or potential customer. The company that is billed in business transactions. 

| Setting | Value | 
|---|---|
| Collection Name | Accounts | 
| Logical Name | account | 
| Primary attribute name | accountid | 
| Object Type Code | 1 | 
| Is custom table | No | 



---


## Attributes

| Display Name | Logical Name | Datatype | Description | 
|---|---|---|---|
| Email Address 3 | emailaddress3 | String | Type an alternate email address for the account. | 
| Email Address 2 | emailaddress2 | String | Type the secondary email address for the account. | 
| Email | emailaddress1 | String | Type the primary email address for the account. | 
| Address 1: City | address1_city | String | Type the city for the primary address. | 
| Address 1: Street 1 | address1_line1 | String | Type the first line of the primary address. | 
| Created By (IP Address) | adx_createdbyipaddress | String |  | 
| Modified On | modifiedon | DateTime | Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. | 
| Aging 90 | aging90 | Money | For system use only. | 
| Record Created On | overriddencreatedon | DateTime | Date and time that the record was migrated. | 
| Website | websiteurl | String | Type the account's website URL to get quick details about the company profile. | 
| Address 1: Longitude | address1_longitude | Double | Type the longitude value for the primary address for use in mapping and other applications. | 
| Open Revenue | openrevenue | Money | Sum of open revenue against an account and its child accounts. | 
| Address 1: Address Type | address1_addresstypecode | Picklist | Select the primary address type. | 
| Shares Outstanding | sharesoutstanding | Integer | Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis. | 
| Modified By (User Name) | adx_modifiedbyusername | String |  | 
| Send Marketing Materials | donotsendmm | Boolean | Select whether the account accepts marketing materials, such as brochures or catalogs. | 
| Credit Hold | creditonhold | Boolean | Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer. | 
| Aging 30 | aging30 | Money | For system use only. | 
| Do not allow Bulk Mails | donotbulkpostalmail | Boolean | Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail. | 
| Created By (Delegate) | createdonbehalfby | Lookup | Shows who created the record on behalf of another user. | 
| Main Phone | telephone1 | String | Type the main phone number for this account. | 
| UTC Conversion Time Zone Code | utcconversiontimezonecode | Integer | Time zone code that was in use when the record was created. | 
| Address 1: Shipping Method | address1_shippingmethodcode | Picklist | Select a shipping method for deliveries sent to this address. | 
| Open Deals (Last Updated On) | opendeals_date | DateTime | Last Updated time of rollup field Open Deals. | 
| Originating Lead | originatingleadid | Lookup | Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics. | 
| Category | accountcategorycode | Picklist | Select a category to indicate whether the customer account is standard or preferred. | 
| Address 2: State/Province | address2_stateorprovince | String | Type the state or province of the secondary address. | 
| Managing Partner | msa_managingpartnerid | Lookup | Unique identifier for Account associated with Account. | 
| Address 2: Country/Region | address2_country | String | Type the country or region for the secondary address. | 
| Address 2: Street 2 | address2_line2 | String | Type the second line of the secondary address. | 
| Aging 60 (Base) | aging60_base | Money | The base currency equivalent of the aging 60 field. | 
| SLA | slaid | Lookup | Choose the service level agreement (SLA) that you want to apply to the Account record. | 
| Address 1: Street 3 | address1_line3 | String | Type the third line of the primary address. | 
| Account Name | name | String | Type the company or business name. | 
| On Hold Time (Minutes) | onholdtime | Integer | Shows how long, in minutes, that the record was on hold. | 
| Status | statecode | State | Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated. | 
| Address 1: Freight Terms | address1_freighttermscode | Picklist | Select the freight terms for the primary address to make sure shipping orders are processed correctly. | 
| Credit Limit | creditlimit | Money | Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer. | 
| Open Revenue (Base) | openrevenue_base | Money | Value of the Open Revenue in base currency. | 
| Address 1: UTC Offset | address1_utcoffset | Integer | Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address. | 
| Parent Account | parentaccountid | Lookup | Choose the parent account associated with this account to show parent and child businesses in reporting and analytics. | 
| Preferred Time | preferredappointmenttimecode | Picklist | Select the preferred time of day for service appointments. | 
| Number of Employees | numberofemployees | Integer | Type the number of employees that work at the account for use in marketing segmentation and demographic analysis. | 
| Classification | accountclassificationcode | Picklist | Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria. | 
| Credit Limit (Base) | creditlimit_base | Money | Shows the credit limit converted to the system's default base currency for reporting purposes. | 
| Exchange Rate | exchangerate | Decimal | Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency. | 
| Address 2: County | address2_county | String | Type the county for the secondary address. | 
| Primary Contact | primarycontactid | Lookup | Choose the primary contact for the account to provide quick access to contact details. | 
| Telephone 3 | telephone3 | String | Type a third phone number for this account. | 
| Customer Size | customersizecode | Picklist | Select the size category or range of the account for segmentation and reporting purposes. | 
| Address 2: City | address2_city | String | Type the city for the secondary address. | 
| Status Reason | statuscode | Status | Select the account's status. | 
| Address 2: Latitude | address2_latitude | Double | Type the latitude value for the secondary address for use in mapping and other applications. | 
| Created On | createdon | DateTime | Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. | 
| Do not allow Bulk Emails | donotbulkemail | Boolean | Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email. | 
| Do not allow Faxes | donotfax | Boolean | Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns. | 
| Market Capitalization | marketcap | Money | Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis. | 
| Address 1 | address1_composite | Memo | Shows the complete primary address. | 
| Ownership | ownershipcode | Picklist | Select the account's ownership structure, such as public or private. | 
| Open Deals (State) | opendeals_state | Integer | State of rollup field Open Deals. | 
| Address 2: Freight Terms | address2_freighttermscode | Picklist | Select the freight terms for the secondary address to make sure shipping orders are processed correctly. | 
| Do not allow Mails | donotpostalmail | Boolean | Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns. | 
| Address 2: ZIP/Postal Code | address2_postalcode | String | Type the ZIP Code or postal code for the secondary address. | 
| Last Date Included in Campaign | lastusedincampaign | DateTime | Shows the date when the account was last included in a marketing campaign or quick campaign. | 
| Process | processid | Uniqueidentifier | Shows the ID of the process. | 
| TeamsFollowed | teamsfollowed | Integer | Number of users or conversations followed the record | 
| Address 2: Street 3 | address2_line3 | String | Type the third line of the secondary address. | 
| Description | description | Memo | Type additional information to describe the account, such as an excerpt from the company's website. | 
| Modified By | modifiedby | Lookup | Shows who last updated the record. | 
| Time Zone Rule Version Number | timezoneruleversionnumber | Integer | For internal use only. | 
| Address 1: County | address1_county | String | Type the county for the primary address. | 
| Preferred Method of Contact | preferredcontactmethodcode | Picklist | Select the preferred method of contact. | 
| Modified By (Delegate) | modifiedonbehalfby | Lookup | Shows who created the record on behalf of another user. | 
| Do not allow Emails | donotemail | Boolean | Select whether the account allows direct email sent from Microsoft Dynamics 365. | 
| Address 2: Post Office Box | address2_postofficebox | String | Type the post office box number of the secondary address. | 
| Address 2: Telephone 1 | address2_telephone1 | String | Type the main phone number associated with the secondary address. | 
| Address 2: Telephone 2 | address2_telephone2 | String | Type a second phone number associated with the secondary address. | 
| Address 2: Telephone 3 | address2_telephone3 | String | Type a third phone number associated with the secondary address. | 
| Created By (User Name) | adx_createdbyusername | String |  | 
| Address 1: ID | address1_addressid | Uniqueidentifier | Unique identifier for address 1. | 
| (Deprecated) Traversed Path | traversedpath | String | For internal use only. | 
| Yomi Account Name | yominame | String | Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications. | 
| Owning User | owninguser | Lookup | Unique identifier of the user who owns the account. | 
| Industry | industrycode | Picklist | Select the account's primary industry for use in marketing segmentation and demographic analysis. | 
| Territory | territoryid | Lookup | Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis. | 
| Address 2: Name | address2_name | String | Type a descriptive name for the secondary address, such as Corporate Headquarters. | 
| Open Revenue (State) | openrevenue_state | Integer | State of rollup field Open Revenue. | 
| Primary Satori ID | primarysatoriid | String | Primary Satori ID for Account | 
| Entity Image Id | entityimageid | Uniqueidentifier | For internal use only. | 
| Aging 60 | aging60 | Money | For system use only. | 
| Time Spent by me | timespentbymeonemailandmeetings | String | Total time spent for emails (read and write) and meetings by me in relation to account record. | 
| Modified By (IP Address) | adx_modifiedbyipaddress | String |  | 
| Primary Twitter ID | primarytwitterid | String | Primary Twitter ID for Account | 
| Default Image | entityimage | Virtual | Shows the default image for the record. | 
| Created By (External Party) | createdbyexternalparty | Lookup | Shows the external party who created the record. | 
| Address 2 | address2_composite | Memo | Shows the complete secondary address. | 
| Shipping Method | shippingmethodcode | Picklist | Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option. | 
| Address 1: Country/Region | address1_country | String | Type the country or region for the primary address. | 
| Payment Terms | paymenttermscode | Picklist | Select the payment terms to indicate when the customer needs to pay the total amount. | 
| Owning Team | owningteam | Lookup | Unique identifier of the team who owns the account. | 
| Owning Business Unit | owningbusinessunit | Lookup | Shows the business unit that the record owner belongs to. | 
| Address 1: State/Province | address1_stateorprovince | String | Type the state or province of the primary address. | 
| Marketing Only | marketingonly | Boolean | Whether is only for marketing | 
| Last SLA applied | slainvokedid | Lookup | Last SLA that was applied to this case. This field is for internal use only. | 
| Preferred Facility/Equipment | preferredequipmentid | Lookup | Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer. | 
| Business Type | businesstypecode | Picklist | Select the legal designation or other business type of the account for contracts or reporting purposes. | 
| Annual Revenue | revenue | Money | Type the annual revenue for the account, used as an indicator in financial performance analysis. | 
| Currency | transactioncurrencyid | Lookup | Choose the local currency for the record to make sure budgets are reported in the correct currency. | 
| Account Rating | accountratingcode | Picklist | Select a rating to indicate the value of the customer account. | 
| Address Phone | address1_telephone1 | String | Type the main phone number associated with the primary address. | 
| Address 1: Telephone 2 | address1_telephone2 | String | Type a second phone number associated with the primary address. | 
| Address 1: Telephone 3 | address1_telephone3 | String | Type a third phone number associated with the primary address. | 
| Address 1: Post Office Box | address1_postofficebox | String | Type the post office box number of the primary address. | 
| Follow Email Activity | followemail | Boolean | Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account. | 
| Fax | fax | String | Type the fax number for the account. | 
| Master ID | masterid | Lookup | Shows the master account that the account was merged with. | 
| SIC Code | sic | String | Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis. | 
| Owner | ownerid | Owner | Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. | 
| Address 2: UTC Offset | address2_utcoffset | Integer | Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address. | 
| Account Number | accountnumber | String | Type an ID number or code for the account to quickly search and identify the account in system views. | 
| Address 2: Fax | address2_fax | String | Type the fax number associated with the secondary address. | 
| Annual Revenue (Base) | revenue_base | Money | Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area. | 
| Merged | merged | Boolean | Shows whether the account has been merged with another account. | 
| Address 2: Longitude | address2_longitude | Double | Type the longitude value for the secondary address for use in mapping and other applications. | 
| Modified By (External Party) | modifiedbyexternalparty | Lookup | Shows the external party who modified the record. | 
| Price List | defaultpricelevelid | Lookup | Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders. | 
| FTP Site | ftpsiteurl | String | Type the URL for the account's FTP site to enable users to access data and share documents. | 
| Aging 90 (Base) | aging90_base | Money | The base currency equivalent of the aging 90 field. | 
| Do not allow Phone Calls | donotphone | Boolean | Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns. | 
| Address 1: Primary Contact Name | address1_primarycontactname | String | Type the name of the main contact at the account's primary address. | 
| Last On Hold Time | lastonholdtime | DateTime | Contains the date and time stamp of the last on hold time. | 
| Address 1: Street 2 | address1_line2 | String | Type the second line of the primary address. | 
| Created By | createdby | Lookup | Shows who created the record. | 
| Address 2: Address Type | address2_addresstypecode | Picklist | Select the secondary address type. | 
| Open Revenue (Last Updated On) | openrevenue_date | DateTime | Last Updated time of rollup field Open Revenue. | 
| Market Capitalization (Base) | marketcap_base | Money | Shows the market capitalization converted to the system's default base currency. | 
| Address 1: ZIP/Postal Code | address1_postalcode | String | Type the ZIP Code or postal code for the primary address. | 
| Ticker Symbol | tickersymbol | String | Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money. | 
| (Deprecated) Process Stage | stageid | Uniqueidentifier | Shows the ID of the stage. | 
| Address 2: UPS Zone | address2_upszone | String | Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS. | 
| Participates in Workflow | participatesinworkflow | Boolean | For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data. | 
| Stock Exchange | stockexchange | String | Type the stock exchange at which the account is listed to track their stock and financial performance of the company. | 
| Preferred Service | preferredserviceid | Lookup | Choose the account's preferred service for reference when you schedule service activities. | 
| Address 2: ID | address2_addressid | Uniqueidentifier | Unique identifier for address 2. | 
| Relationship Type | customertypecode | Picklist | Select the category that best describes the relationship between the account and your organization. | 
| Import Sequence Number | importsequencenumber | Integer | Unique identifier of the data import or data migration that created this record. | 
| Other Phone | telephone2 | String | Type a second phone number for this account. | 
| Version Number | versionnumber | BigInt | Version number of the account. | 
| Account | accountid | Uniqueidentifier | Unique identifier of the account. | 
| Preferred User | preferredsystemuserid | Lookup | Choose the preferred service representative for reference when you schedule service activities for the account. | 
| Aging 30 (Base) | aging30_base | Money | The base currency equivalent of the aging 30 field. | 
| Address 1: Name | address1_name | String | Type a descriptive name for the primary address, such as Corporate Headquarters. | 
| Address 1: Fax | address1_fax | String | Type the fax number associated with the primary address. | 
| Address 1: Latitude | address1_latitude | Double | Type the latitude value for the primary address for use in mapping and other applications. | 
| Address 2: Shipping Method | address2_shippingmethodcode | Picklist | Select a shipping method for deliveries sent to this address. | 
| Preferred Day | preferredappointmentdaycode | Picklist | Select the preferred day of the week for service appointments. | 
| Address 2: Street 1 | address2_line1 | String | Type the first line of the secondary address. | 
| Address 1: UPS Zone | address1_upszone | String | Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS. | 
| Territory Code | territorycode | Picklist | Select a region or territory for the account for use in segmentation and analysis. | 
| Address 2: Primary Contact Name | address2_primarycontactname | String | Type the name of the main contact at the account's secondary address. | 
| Open Deals | opendeals | Integer | Number of open opportunities against an account and its child accounts. | 


 

## Relationships

### One to many relationships

| Related entity | Foreign key | Schema name | 
|---|---|---|
| principalobjectattributeaccess | objectid | account_principalobjectattributeaccess | 
| fax | regardingobjectid | Account_Faxes | 
| slakpiinstance | regarding | slakpiinstance_account | 
| postfollow | regardingobjectid | account_PostFollows | 
| postregarding | regardingobjectid | account_PostRegardings | 
| postrole | regardingobjectid | account_PostRoles | 
| task | regardingobjectid | Account_Tasks | 
| connection | record1id | account_connections1 | 
| customerrelationship | customerid | account_customer_relationship_customer | 
| userentityinstancedata | objectid | userentityinstancedata_account | 
| socialactivity | postauthoraccount | SocialActivity_PostAuthorAccount_accounts | 
| duplicaterecord | baserecordid | Account_DuplicateBaseRecord | 
| socialactivity | postauthor | SocialActivity_PostAuthor_accounts | 
| syncerror | regardingobjectid | Account_SyncErrors | 
| mailboxtrackingfolder | regardingobjectid | Account_MailboxTrackingFolder | 
| bulkdeletefailure | regardingobjectid | Account_BulkDeleteFailures | 
| activitypointer | regardingobjectid | Account_ActivityPointers | 
| email | sendersaccount | Account_Email_SendersAccount | 
| appointment | regardingobjectid | Account_Appointments | 
| socialprofile | customerid | Socialprofile_customer_accounts | 
| email | regardingobjectid | Account_Emails | 
| activityparty | partyid | account_activity_parties | 
| phonecall | regardingobjectid | Account_Phonecalls | 
| customerrelationship | partnerid | account_customer_relationship_partner | 
| socialactivity | regardingobjectid | Account_SocialActivities | 
| duplicaterecord | duplicaterecordid | Account_DuplicateMatchingRecord | 
| sharepointdocument | regardingobjectid | Account_SharepointDocument | 
| actioncard | regardingobjectid | account_actioncard | 
| asyncoperation | regardingobjectid | Account_AsyncOperations | 
| customeraddress | parentid | Account_CustomerAddress | 
| annotation | objectid | Account_Annotation | 
| letter | regardingobjectid | Account_Letters | 
| recurringappointmentmaster | regardingobjectid | Account_RecurringAppointmentMasters | 
| email | emailsender | Account_Email_EmailSender | 
| processsession | regardingobjectid | Account_ProcessSessions | 
| account | parentaccountid | account_parent_account | 
| contact | parentcustomerid | contact_customer_accounts | 
| account | masterid | account_master_account | 
| sharepointdocumentlocation | regardingobjectid | Account_SharepointDocumentLocation | 
| connection | record2id | account_connections2 | 
| lead | customerid | lead_customer_accounts | 
| lead | parentaccountid | lead_parent_account | 
| bookableresource | accountid | account_bookableresource_AccountId | 
| bulkoperation | regardingobjectid | account_BulkOperations | 
| campaignresponse | regardingobjectid | account_CampaignResponses | 
| bulkoperationlog | createdobjectid | CreatedAccount_BulkOperationLogs2 | 
| bulkoperationlog | regardingobjectid | SourceAccount_BulkOperationLogs | 
| incidentresolution | regardingobjectid | account_IncidentResolutions | 
| serviceappointment | regardingobjectid | Account_ServiceAppointments | 
| contractdetail | customerid | contractlineitem_customer_accounts | 
| contract | billingcustomerid | contract_billingcustomer_accounts | 
| contract | customerid | contract_customer_accounts | 
| incident | customerid | incident_customer_accounts | 
| entitlement | accountid | account_entitlement_Account | 
| entitlement | customerid | account_entitlement_Customer | 
| msdyn_customerasset | msdyn_account | msdyn_account_msdyn_customerasset_Account | 
| msdyn_iotdevice | msdyn_account | msdyn_account_msdyn_iotdevice_Account | 
| opportunityclose | regardingobjectid | account_OpportunityCloses | 
| orderclose | regardingobjectid | account_OrderCloses | 
| quoteclose | regardingobjectid | account_QuoteCloses | 
| customeropportunityrole | customerid | account_customer_opportunity_roles | 
| invoice | customerid | invoice_customer_accounts | 
| opportunity | customerid | opportunity_customer_accounts | 
| salesorder | customerid | order_customer_accounts | 
| quote | customerid | quote_customer_accounts | 
| opportunity | parentaccountid | opportunity_parent_account | 
| msdyn_playbookinstance | regarding | msdyn_playbookinstance_account | 
| msfp_alert | regardingobjectid | account_msfp_alerts | 
| msfp_surveyinvite | regardingobjectid | account_msfp_surveyinvites | 
| msfp_surveyresponse | regardingobjectid | account_msfp_surveyresponses | 
| msdyn_bookingalert | regardingobjectid | account_msdyn_bookingalerts | 
| msdyn_actual | msdyn_accountcustomer | msdyn_account_msdyn_actual_AccountCustomer | 
| msdyn_actual | msdyn_accountvendor | msdyn_account_msdyn_actual_AccountVendor | 
| account | msa_managingpartnerid | msa_account_managingpartner | 
| contact | msa_managingpartnerid | msa_contact_managingpartner | 
| incident | msa_partnerid | msa_account_incident | 
| opportunity | msa_partnerid | msa_partner_opportunity | 
| adx_alertsubscription | regardingobjectid | account_adx_alertsubscriptions | 
| adx_inviteredemption | regardingobjectid | account_adx_inviteredemptions | 
| adx_invitation | adx_assigntoaccount | adx_invitation_assigntoaccount | 
| adx_portalcomment | regardingobjectid | account_adx_portalcomments | 
| post | regardingobjectid | account_Posts | 


 

### Many to relationships

| Primary entity | Foreign key | Schema name | 
|---|---|---|
| principalobjectattributeaccess | objectid | account_principalobjectattributeaccess | 
| fax | regardingobjectid | Account_Faxes | 
| slakpiinstance | regarding | slakpiinstance_account | 
| postfollow | regardingobjectid | account_PostFollows | 
| postregarding | regardingobjectid | account_PostRegardings | 
| postrole | regardingobjectid | account_PostRoles | 
| task | regardingobjectid | Account_Tasks | 
| connection | record1id | account_connections1 | 
| customerrelationship | customerid | account_customer_relationship_customer | 
| userentityinstancedata | objectid | userentityinstancedata_account | 
| socialactivity | postauthoraccount | SocialActivity_PostAuthorAccount_accounts | 
| duplicaterecord | baserecordid | Account_DuplicateBaseRecord | 
| socialactivity | postauthor | SocialActivity_PostAuthor_accounts | 
| syncerror | regardingobjectid | Account_SyncErrors | 
| mailboxtrackingfolder | regardingobjectid | Account_MailboxTrackingFolder | 
| bulkdeletefailure | regardingobjectid | Account_BulkDeleteFailures | 
| activitypointer | regardingobjectid | Account_ActivityPointers | 
| email | sendersaccount | Account_Email_SendersAccount | 
| appointment | regardingobjectid | Account_Appointments | 
| socialprofile | customerid | Socialprofile_customer_accounts | 
| email | regardingobjectid | Account_Emails | 
| activityparty | partyid | account_activity_parties | 
| phonecall | regardingobjectid | Account_Phonecalls | 
| customerrelationship | partnerid | account_customer_relationship_partner | 
| socialactivity | regardingobjectid | Account_SocialActivities | 
| duplicaterecord | duplicaterecordid | Account_DuplicateMatchingRecord | 
| sharepointdocument | regardingobjectid | Account_SharepointDocument | 
| actioncard | regardingobjectid | account_actioncard | 
| asyncoperation | regardingobjectid | Account_AsyncOperations | 
| customeraddress | parentid | Account_CustomerAddress | 
| annotation | objectid | Account_Annotation | 
| letter | regardingobjectid | Account_Letters | 
| recurringappointmentmaster | regardingobjectid | Account_RecurringAppointmentMasters | 
| email | emailsender | Account_Email_EmailSender | 
| processsession | regardingobjectid | Account_ProcessSessions | 
| account | parentaccountid | account_parent_account | 
| contact | parentcustomerid | contact_customer_accounts | 
| account | masterid | account_master_account | 
| sharepointdocumentlocation | regardingobjectid | Account_SharepointDocumentLocation | 
| connection | record2id | account_connections2 | 
| lead | customerid | lead_customer_accounts | 
| lead | parentaccountid | lead_parent_account | 
| bookableresource | accountid | account_bookableresource_AccountId | 
| bulkoperation | regardingobjectid | account_BulkOperations | 
| campaignresponse | regardingobjectid | account_CampaignResponses | 
| bulkoperationlog | createdobjectid | CreatedAccount_BulkOperationLogs2 | 
| bulkoperationlog | regardingobjectid | SourceAccount_BulkOperationLogs | 
| incidentresolution | regardingobjectid | account_IncidentResolutions | 
| serviceappointment | regardingobjectid | Account_ServiceAppointments | 
| contractdetail | customerid | contractlineitem_customer_accounts | 
| contract | billingcustomerid | contract_billingcustomer_accounts | 
| contract | customerid | contract_customer_accounts | 
| incident | customerid | incident_customer_accounts | 
| entitlement | accountid | account_entitlement_Account | 
| entitlement | customerid | account_entitlement_Customer | 
| msdyn_customerasset | msdyn_account | msdyn_account_msdyn_customerasset_Account | 
| msdyn_iotdevice | msdyn_account | msdyn_account_msdyn_iotdevice_Account | 
| opportunityclose | regardingobjectid | account_OpportunityCloses | 
| orderclose | regardingobjectid | account_OrderCloses | 
| quoteclose | regardingobjectid | account_QuoteCloses | 
| customeropportunityrole | customerid | account_customer_opportunity_roles | 
| invoice | customerid | invoice_customer_accounts | 
| opportunity | customerid | opportunity_customer_accounts | 
| salesorder | customerid | order_customer_accounts | 
| quote | customerid | quote_customer_accounts | 
| opportunity | parentaccountid | opportunity_parent_account | 
| msdyn_playbookinstance | regarding | msdyn_playbookinstance_account | 
| msfp_alert | regardingobjectid | account_msfp_alerts | 
| msfp_surveyinvite | regardingobjectid | account_msfp_surveyinvites | 
| msfp_surveyresponse | regardingobjectid | account_msfp_surveyresponses | 
| msdyn_bookingalert | regardingobjectid | account_msdyn_bookingalerts | 
| msdyn_actual | msdyn_accountcustomer | msdyn_account_msdyn_actual_AccountCustomer | 
| msdyn_actual | msdyn_accountvendor | msdyn_account_msdyn_actual_AccountVendor | 
| account | msa_managingpartnerid | msa_account_managingpartner | 
| contact | msa_managingpartnerid | msa_contact_managingpartner | 
| incident | msa_partnerid | msa_account_incident | 
| opportunity | msa_partnerid | msa_partner_opportunity | 
| adx_alertsubscription | regardingobjectid | account_adx_alertsubscriptions | 
| adx_inviteredemption | regardingobjectid | account_adx_inviteredemptions | 
| adx_invitation | adx_assigntoaccount | adx_invitation_assigntoaccount | 
| adx_portalcomment | regardingobjectid | account_adx_portalcomments | 
| post | regardingobjectid | account_Posts | 


 

