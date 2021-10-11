# Contact

Person with whom a business unit has a relationship, such as customer, supplier, and colleague. 

| Setting | Value | 
|---|---|
| Collection Name | Contacts | 
| Logical Name | contact | 
| Primary attribute name | contactid | 
| Object Type Code | 2 | 
| Is custom table | No | 



---


## Attributes

| Display Name | Logical Name | Datatype | Description | 
|---|---|---|---|
| Address 1: County | address1_county | String | Type the county for the primary address. | 
| Yomi Last Name | yomilastname | String | Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact. | 
| Address 3: UTC Offset | address3_utcoffset | Integer | Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address. | 
| Description | description | Memo | Type additional information to describe the contact, such as an excerpt from the company's website. | 
| Department | department | String | Type the department or business unit where the contact works in the parent company or business. | 
| Has Children | haschildrencode | Picklist | Select whether the contact has any children for reference in follow-up phone calls and other communications. | 
| Address 1: ID | address1_addressid | Uniqueidentifier | Unique identifier for address 1. | 
| Back Office Customer | isbackofficecustomer | Boolean | Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes. | 
| Import Sequence Number | importsequencenumber | Integer | Unique identifier of the data import or data migration that created this record. | 
| Profile Is Anonymous | adx_profileisanonymous | Boolean |  | 
| Access Failed Count | adx_identity_accessfailedcount | Integer | Shows the current count of failed password attempts for the contact. | 
| Manager | managername | String | Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact. | 
| Profile Last Activity | adx_profilelastactivity | DateTime |  | 
| Entity Image Id | entityimageid | Uniqueidentifier | For internal use only. | 
| Home Phone | telephone2 | String | Type a second phone number for this contact. | 
| Parent Customer Type | parentcustomeridtype | EntityName |  | 
| Address 2: UPS Zone | address2_upszone | String | Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS. | 
| Relationship Type | customertypecode | Picklist | Select the category that best describes the relationship between the contact and your organization. | 
| Address 1: UPS Zone | address1_upszone | String | Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS. | 
| Address 1: Freight Terms | address1_freighttermscode | Picklist | Select the freight terms for the primary address to make sure shipping orders are processed correctly. | 
| Do not allow Bulk Mails | donotbulkpostalmail | Boolean | Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters. | 
| Gender | gendercode | Picklist | Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. | 
| Do not allow Mails | donotpostalmail | Boolean | Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns. | 
| Last On Hold Time | lastonholdtime | DateTime | Contains the date and time stamp of the last on hold time. | 
| Address 1: Address Type | address1_addresstypecode | Picklist | Select the primary address type. | 
| Address 1: Phone | address1_telephone1 | String | Type the main phone number associated with the primary address. | 
| Address 1: Telephone 2 | address1_telephone2 | String | Type a second phone number associated with the primary address. | 
| Address 1: Telephone 3 | address1_telephone3 | String | Type a third phone number associated with the primary address. | 
| Address 1: Fax | address1_fax | String | Type the fax number associated with the primary address. | 
| Address 3: Telephone1 | address3_telephone1 | String | Type the main phone number associated with the third address. | 
| Address 3: Telephone2 | address3_telephone2 | String | Type a second phone number associated with the third address. | 
| Address 3: Telephone3 | address3_telephone3 | String | Type a third phone number associated with the primary address. | 
| Fax | fax | String | Type the fax number for the contact. | 
| Assistant | assistantname | String | Type the name of the contact's assistant. | 
| Address 2: Street 3 | address2_line3 | String | Type the third line of the secondary address. | 
| Mobile Phone | mobilephone | String | Type the mobile phone number for the contact. | 
| Owning Business Unit | owningbusinessunit | Lookup | Unique identifier of the business unit that owns the contact. | 
| Full Name | fullname | String | Combines and shows the contact's first and last names so that the full name can be displayed in views and reports. | 
| Address 2: Longitude | address2_longitude | Double | Type the longitude value for the secondary address for use in mapping and other applications. | 
| Subscription | subscriptionid | Uniqueidentifier | For internal use only. | 
| GDPR Optout | msdyn_gdproptout | Boolean | Describes whether contact is opted out or not | 
| Version Number | versionnumber | BigInt | Version number of the contact. | 
| Address 1: Latitude | address1_latitude | Double | Type the latitude value for the primary address for use in mapping and other applications. | 
| Aging 30 | aging30 | Money | For system use only. | 
| Security Stamp | adx_identity_securitystamp | String | A token used to manage the web authentication session. | 
| Last Date Included in Campaign | lastusedincampaign | DateTime | Shows the date when the contact was last included in a marketing campaign or quick campaign. | 
| User Name | adx_identity_username | String | Shows the user identity for local web authentication. | 
| Address 3: Fax | address3_fax | String | Type the fax number associated with the third address. | 
| Address 2: Telephone 1 | address2_telephone1 | String | Type the main phone number associated with the secondary address. | 
| Preferred Time | preferredappointmenttimecode | Picklist | Select the preferred time of day for service appointments. | 
| Credit Limit (Base) | creditlimit_base | Money | Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area. | 
| Preferred Service | preferredserviceid | Lookup | Choose the contact's preferred service to make sure services are scheduled correctly for the customer. | 
| Pager | pager | String | Type the pager number for the contact. | 
| Salutation | salutation | String | Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns. | 
| Address 2: City | address2_city | String | Type the city for the secondary address. | 
| Address3: ZIP/Postal Code | address3_postalcode | String | the ZIP Code or postal code for the 3rd address. | 
| Address 2: Street 2 | address2_line2 | String | Type the second line of the secondary address. | 
| Aging 60 | aging60 | Money | For system use only. | 
| Organization Name | adx_organizationname | String |  | 
| Mobile Phone Confirmed | adx_identity_mobilephoneconfirmed | Boolean | Determines if the phone number is confirmed by the contact. | 
| Portal Terms Agreement Date | msdyn_portaltermsagreementdate | DateTime | Indicates the date and time that the person agreed to the portal terms and conditions. | 
| Aging 90 | aging90 | Money | For system use only. | 
| Created By (External Party) | createdbyexternalparty | Lookup | Shows the external party who created the record. | 
| Address 3: UPS Zone | address3_upszone | String | Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS. | 
| Address 3: County | address3_county | String | Type the county for the third address. | 
| Government | governmentid | String | Type the passport number or other government ID for the contact for use in documents or reports. | 
| Callback Number | callback | String | Type a callback phone number for this contact. | 
| Credit Hold | creditonhold | Boolean | Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues. |  
| Address 2: Freight Terms | address2_freighttermscode | Picklist | Select the freight terms for the secondary address to make sure shipping orders are processed correctly. | 
| Business Phone 2 | business2 | String | Type a second business phone number for this contact. | 
| Modified By (Delegate) | modifiedonbehalfby | Lookup | Shows who last updated the record on behalf of another user. | 
| Currency | transactioncurrencyid | Lookup | Choose the local currency for the record to make sure budgets are reported in the correct currency. | 
| Not at Company Flag | msdyn_orgchangestatus | Picklist | Whether or not the contact belongs to the associated account | 
| Yomi Full Name | yomifullname | String | Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports. | 
| Address 2: Telephone 2 | address2_telephone2 | String | Type a second phone number associated with the secondary address. | 
| Payment Terms | paymenttermscode | Picklist | Select the payment terms to indicate when the customer needs to pay the total amount. | 
| Address 2: ZIP/Postal Code | address2_postalcode | String | Type the ZIP Code or postal code for the secondary address. | 
| Birthday | birthdate | DateTime | Enter the contact's birthday for use in customer gift programs or other communications. | 
| Address3: Street 3 | address3_line3 | String | the third line of the 3rd address. | 
| Spouse/Partner Name | spousesname | String | Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact. | 
| Address 1: UTC Offset | address1_utcoffset | Integer | Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address. | 
| Yomi Middle Name | yomimiddlename | String | Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact. | 
| (Deprecated) Traversed Path | traversedpath | String | For internal use only. | 
| Exchange Rate | exchangerate | Decimal | Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency. | 
| Time Zone | adx_timezone | Integer |  | 
| Modified By (External Party) | modifiedbyexternalparty | Lookup | Shows the external party who modified the record. | 
| Address 1: Street 3 | address1_line3 | String | Type the third line of the primary address. | 
| Last Successful Login | adx_identity_lastsuccessfullogin | DateTime | Indicates the last date and time the user successfully signed in to a portal. | 
| Address3: Country/Region | address3_country | String | the country or region for the 3rd address. | 
| Disable Web Tracking | msdyn_disablewebtracking | Boolean | Indicates that the contact has opted out of web tracking. | 
| Address 2: Street 1 | address2_line1 | String | Type the first line of the secondary address. | 
| Role | accountrolecode | Picklist | Select the contact's role within the company or sales process, such as decision maker, employee, or influencer. | 
| Middle Name | middlename | String | Type the contact's middle name or initial to make sure the contact is addressed correctly. | 
| Manager Phone | managerphone | String | Type the phone number for the contact's manager. | 
| Address 2: State/Province | address2_stateorprovince | String | Type the state or province of the secondary address. | 
| Company Name | parentcustomerid | Customer | Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. | 
| Address 2: Name | address2_name | String | Type a descriptive name for the secondary address, such as Corporate Headquarters. | 
| Address 3: ID | address3_addressid | Uniqueidentifier | Unique identifier for address 3. | 
| Address3: State/Province | address3_stateorprovince | String | the state or province of the third address. | 
| Login Enabled | adx_identity_logonenabled | Boolean | Determines if web authentication is enabled for the contact. | 
| Entity Image | entityimage | Virtual | Shows the default image for the record. | 
| Address3: Street 1 | address3_line1 | String | the first line of the 3rd address. | 
| Created By IP Address | adx_createdbyipaddress | String |  | 
| BusinessCardAttributes | businesscardattributes | String | Stores Business Card Control Properties. | 
| Anniversary | anniversary | DateTime | Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications. | 
| Territory | territorycode | Picklist | Select a region or territory for the contact for use in segmentation and analysis. | 
| Send Marketing Materials | donotsendmm | Boolean | Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives. | 
| Do not allow Bulk Emails | donotbulkemail | Boolean | Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email. | 
| Address 1: Primary Contact Name | address1_primarycontactname | String | Type the name of the main contact at the account's primary address. | 
| Preferred User | preferredsystemuserid | Lookup | Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact. | 
| Profile Modified On | adx_profilemodifiedon | DateTime |  | 
| Address 2: UTC Offset | address2_utcoffset | Integer | Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address. | 
| Home Phone 2 | home2 | String | Type a second home phone number for this contact. | 
| Address Name | address1_name | String | Type a descriptive name for the primary address, such as Corporate Headquarters. | 
| Children's Names | childrensnames | String | Type the names of the contact's children for reference in communications and client programs. | 
| Address 2: Telephone 3 | address2_telephone3 | String | Type a third phone number associated with the secondary address. | 
| Address 3: Primary Contact Name | address3_primarycontactname | String | Type the name of the main contact at the account's third address. | 
| FTP Site | ftpsiteurl | String | Type the URL for the contact's FTP site to enable users to access data and share documents. | 
| Address 1: ZIP/Postal Code | address1_postalcode | String | Type the ZIP Code or postal code for the primary address. | 
| Two Factor Enabled | adx_identity_twofactorenabled | Boolean | Determines if two-factor authentication is enabled for the contact. | 
| Address 3: Freight Terms | address3_freighttermscode | Picklist | Select the freight terms for the third address to make sure shipping orders are processed correctly. | 
| Created On | createdon | DateTime | Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. | 
| SLA | slaid | Lookup | Choose the service level agreement (SLA) that you want to apply to the Contact record. | 
| Originating Lead | originatingleadid | Lookup | Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics. | 
| Address 1: State/Province | address1_stateorprovince | String | Type the state or province of the primary address. | 
| Follow Email Activity | followemail | Boolean | Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact. | 
| Aging 90 (Base) | aging90_base | Money | Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area. | 
| Job Title | jobtitle | String | Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. | 
| Telephone 3 | telephone3 | String | Type a third phone number for this contact. | 
| Annual Income (Base) | annualincome_base | Money | Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area. | 
| Price List | defaultpricelevelid | Lookup | Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders. | 
| Address 1: Shipping Method | address1_shippingmethodcode | Picklist | Select a shipping method for deliveries sent to this address. | 
| Address 1: Longitude | address1_longitude | Double | Type the longitude value for the primary address for use in mapping and other applications. | 
| Preferred Day | preferredappointmentdaycode | Picklist | Select the preferred day of the week for service appointments. | 
| Aging 60 (Base) | aging60_base | Money | Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area. | 
| Address 2: Fax | address2_fax | String | Type the fax number associated with the secondary address. | 
| New Password Input | adx_identity_newpassword | String |  | 
| Customer Size | customersizecode | Picklist | Select the size of the contact's company for segmentation and reporting purposes. | 
| Status | statecode | State | Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated. | 
| Annual Income | annualincome | Money | Type the contact's annual income for use in profiling and financial analysis. | 
| Status Reason | statuscode | Status | Select the contact's status. | 
| Profile Alert Instructions | adx_profilealertinstructions | Memo |  | 
| Employee | employeeid | String | Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization. | 
| UPRN | address1_postofficebox | String | Type the post office box number of the primary address. | 
| Address 1: City | address1_city | String | Type the city for the primary address. | 
| TeamsFollowed | teamsfollowed | Integer | Number of users or conversations followed the record | 
| Credit Limit | creditlimit | Money | Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer. | 
| Time Zone Rule Version Number | timezoneruleversionnumber | Integer | For internal use only. | 
| Owning User | owninguser | Lookup | Unique identifier of the user who owns the contact. | 
| Preferred Method of Contact | preferredcontactmethodcode | Picklist | Select the preferred method of contact. | 
| Lead Source | leadsourcecode | Picklist | Select the primary marketing source that directed the contact to your organization. | 
| Address3: Street 2 | address3_line2 | String | the second line of the 3rd address. | 
| Last SLA applied | slainvokedid | Lookup | Last SLA that was applied to this case. This field is for internal use only. | 
| Preferred Facility/Equipment | preferredequipmentid | Lookup | Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer. | 
| Public Profile Copy | adx_publicprofilecopy | Memo |  | 
| Participates in Workflow | participatesinworkflow | Boolean | Shows whether the contact participates in workflow rules. | 
| Lockout End Date | adx_identity_lockoutenddate | DateTime | Shows the moment in time when the locked contact becomes unlocked again. | 
| Modified By IP Address | adx_modifiedbyipaddress | String |  | 
| Address 2: Post Office Box | address2_postofficebox | String | Type the post office box number of the secondary address. | 
| Is Minor with Parental Consent | msdyn_isminorwithparentalconsent | Boolean | Indicates that the contact is considered a minor in their jurisdiction and has parental consent. | 
| Email Address 3 | emailaddress3 | String | Type an alternate email address for the contact. | 
| Email Address 2 | emailaddress2 | String | Type the secondary email address for the contact. | 
| Email | emailaddress1 | String | Type the primary email address for the contact. | 
| Created By Username | adx_createdbyusername | String |  | 
| Website | websiteurl | String | Type the contact's professional or personal website or blog URL. | 
| Nickname | nickname | String | Type the contact's nickname. | 
| Address 3: Name | address3_name | String | Type a descriptive name for the third address, such as Corporate Headquarters. | 
| Last Name | lastname | String | Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. | 
| Address 3: Longitude | address3_longitude | Double | Type the longitude value for the third address for use in mapping and other applications. | 
| Merged | merged | Boolean | Shows whether the account has been merged with a master contact. | 
| On Hold Time (Minutes) | onholdtime | Integer | Shows how long, in minutes, that the record was on hold. | 
| Marketing Only | marketingonly | Boolean | Whether is only for marketing | 
| Address 3: Shipping Method | address3_shippingmethodcode | Picklist | Select a shipping method for deliveries sent to this address. | 
| Owner | ownerid | Owner | Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. | 
| Business Phone | telephone1 | String | Type the main phone number for this contact. | 
| Address 2: Address Type | address2_addresstypecode | Picklist | Select the secondary address type. | 
| Password Hash | adx_identity_passwordhash | String |  | 
| Address 3: Post Office Box | address3_postofficebox | String | the post office box number of the 3rd address. | 
| Modified By Username | adx_modifiedbyusername | String |  | 
| Assistant Phone | assistantphone | String | Type the phone number for the contact's assistant. | 
| Address 2: ID | address2_addressid | Uniqueidentifier | Unique identifier for address 2. | 
| Address 1 | address1_composite | Memo | Shows the complete primary address. | 
| Do not allow Faxes | donotfax | Boolean | Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns. | 
| Profile Alert | adx_profilealert | Boolean |  | 
| Preferred Language | adx_preferredlanguageid | Lookup | User’s preferred portal language | 
| Is Minor | msdyn_isminor | Boolean | Indicates that the contact is considered a minor in their jurisdiction. | 
| Address 2: Shipping Method | address2_shippingmethodcode | Picklist | Select a shipping method for deliveries sent to this address. | 
| Address 2: Country/Region | address2_country | String | Type the country or region for the secondary address. | 
| Profile Alert Date | adx_profilealertdate | DateTime |  | 
| Address 1: Street 1 | address1_line1 | String | Type the first line of the primary address. | 
| Yomi First Name | yomifirstname | String | Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact. | 
| Address 3: City | address3_city | String | Type the city for the 3rd address. | 
| Address 1: Country/Region | address1_country | String | Type the country or region for the primary address. | 
| External User Identifier | externaluseridentifier | String | Identifier for an external user. | 
| First Name | firstname | String | Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. |  
| (Deprecated) Process Stage | stageid | Uniqueidentifier | Shows the ID of the stage. | 
| Modified By | modifiedby | Lookup | Shows who last updated the record. | 
| Local Login Disabled | adx_identity_locallogindisabled | Boolean | Indicates that the contact can no longer sign in to the portal using the local account. | 
| Do not allow Phone Calls | donotphone | Boolean | Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns. | 
| Suffix | suffix | String | Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. | 
| Master ID | masterid | Lookup | Unique identifier of the master contact for merge. | 
| Parent Contact | parentcontactid | Lookup | Unique identifier of the parent contact. | 
| Time Spent by me | timespentbymeonemailandmeetings | String | Total time spent for emails (read and write) and meetings by me in relation to the contact record. | 
| Address 2: Latitude | address2_latitude | Double | Type the latitude value for the secondary address for use in mapping and other applications. | 
| Address 3 | address3_composite | Memo | Shows the complete third address. | 
| Record Created On | overriddencreatedon | DateTime | Date and time that the record was migrated. | 
| Address 3: Address Type | address3_addresstypecode | Picklist | Select the third address type. | 
| Aging 30 (Base) | aging30_base | Money | Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area. | 
| Marital Status | familystatuscode | Picklist | Select the marital status of the contact for reference in follow-up phone calls and other communications. | 
| UTC Conversion Time Zone Code | utcconversiontimezonecode | Integer | Time zone code that was in use when the record was created. | 
| Address 2: County | address2_county | String | Type the county for the secondary address. | 
| Contact | contactid | Uniqueidentifier | Unique identifier of the contact. | 
| Address 2: Primary Contact Name | address2_primarycontactname | String | Type the name of the main contact at the account's secondary address. | 
| Shipping Method | shippingmethodcode | Picklist | Select a shipping method for deliveries sent to this address. | 
| Owning Team | owningteam | Lookup | Unique identifier of the team who owns the contact. | 
| Address 1: Street 2 | address1_line2 | String | Type the second line of the primary address. | 
| Auto-created | isautocreate | Boolean | Information about whether the contact was auto-created when promoting an email or an appointment. | 
| Managing Partner | msa_managingpartnerid | Lookup | Unique identifier for Account associated with Contact. | 
| Do not allow Emails | donotemail | Boolean | Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email. | 
| Process | processid | Uniqueidentifier | Shows the ID of the process. | 
| Education | educationcode | Picklist | Select the contact's highest level of education for use in segmentation and analysis. | 
| Modified On | modifiedon | DateTime | Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. | 
| Account | accountid | Lookup | Unique identifier of the account with which the contact is associated. |  
| Business Card | businesscard | Memo | Stores Image of the Business Card | 
| Company Phone | company | String | Type the company phone of the contact. | 
| Created By (Delegate) | createdonbehalfby | Lookup | Shows who created the record on behalf of another user. | 
| Confirm Remove Password | adx_confirmremovepassword | Boolean |  | 
| Address 2 | address2_composite | Memo | Shows the complete secondary address. | 
| Created By | createdby | Lookup | Shows who created the record. | 
| Lockout Enabled | adx_identity_lockoutenabled | Boolean | Determines if this contact will track failed access attempts and become locked after too many failed attempts. To prevent the contact from becoming locked, you can disable this setting. | 
| No. of Children | numberofchildren | Integer | Type the number of children the contact has for reference in follow-up phone calls and other communications. | 
| Address 3: Latitude | address3_latitude | Double | Type the latitude value for the third address for use in mapping and other applications. | 
| Email Confirmed | adx_identity_emailaddress1confirmed | Boolean | Determines if the email is confirmed by the contact. | 


 

## Relationships

### One to many relationships

| Related entity | Foreign key | Schema name | 
|---|---|---|
| principalobjectattributeaccess | objectid | contact_principalobjectattributeaccess | 
| slakpiinstance | regarding | slakpiinstance_contact | 
| socialactivity | postauthoraccount | socialactivity_postauthoraccount_contacts | 
| email | emailsender | Contact_Email_EmailSender | 
| task | regardingobjectid | Contact_Tasks | 
| postfollow | regardingobjectid | contact_PostFollows | 
| postrole | regardingobjectid | contact_PostRoles | 
| postregarding | regardingobjectid | contact_PostRegardings | 
| recurringappointmentmaster | regardingobjectid | Contact_RecurringAppointmentMasters | 
| contact | masterid | contact_master_contact | 
| customerrelationship | partnerid | contact_customer_relationship_partner | 
| feedback | createdbycontact | lk_contact_feedback_createdby | 
| actioncard | regardingobjectid | contact_actioncard | 
| connection | record2id | contact_connections2 | 
| bulkdeletefailure | regardingobjectid | Contact_BulkDeleteFailures | 
| activityparty | partyid | contact_activity_parties | 
| duplicaterecord | baserecordid | Contact_DuplicateBaseRecord | 
| annotation | objectid | Contact_Annotation | 
| socialactivity | regardingobjectid | Contact_SocialActivities | 
| activitypointer | regardingobjectid | Contact_ActivityPointers | 
| mailboxtrackingfolder | regardingobjectid | Contact_MailboxTrackingFolder | 
| account | primarycontactid | account_primary_contact | 
| socialprofile | customerid | Socialprofile_customer_contacts | 
| externalpartyitem | regardingobjectid | Contact_ExternalPartyItems | 
| socialactivity | postauthor | socialactivity_postauthor_contacts | 
| feedback | createdonbehalfbycontact | lk_contact_feedback_createdonbehalfby | 
| email | regardingobjectid | Contact_Emails | 
| appointment | regardingobjectid | Contact_Appointments | 
| feedback | regardingobjectid | Contact_Feedback | 
| processsession | regardingobjectid | Contact_ProcessSessions | 
| asyncoperation | regardingobjectid | Contact_AsyncOperations | 
| connection | record1id | contact_connections1 | 
| customeraddress | parentid | Contact_CustomerAddress | 
| phonecall | regardingobjectid | Contact_Phonecalls | 
| contact | parentcustomerid | contact_customer_contacts | 
| userentityinstancedata | objectid | userentityinstancedata_contact | 
| syncerror | regardingobjectid | Contact_SyncErrors | 
| duplicaterecord | duplicaterecordid | Contact_DuplicateMatchingRecord | 
| customerrelationship | customerid | contact_customer_relationship_customer | 
| fax | regardingobjectid | Contact_Faxes | 
| letter | regardingobjectid | Contact_Letters | 
| lead | customerid | lead_customer_contacts | 
| lead | parentcontactid | lead_parent_contact | 
| bookableresource | contactid | contact_bookableresource_ContactId | 
| bulkoperation | regardingobjectid | contact_BulkOperations | 
| campaignresponse | regardingobjectid | contact_CampaignResponses | 
| bulkoperationlog | createdobjectid | CreatedContact_BulkOperationLogs | 
| bulkoperationlog | regardingobjectid | SourceContact_BulkOperationLogs | 
| serviceappointment | regardingobjectid | Contact_ServiceAppointments | 
| incident | responsiblecontactid | contact_as_responsible_contact | 
| contractdetail | customerid | contractlineitem_customer_contacts | 
| contract | billingcustomerid | contract_billingcustomer_contacts | 
| contract | customerid | contract_customer_contacts | 
| incident | customerid | incident_customer_contacts | 
| incident | primarycontactid | contact_as_primary_contact | 
| entitlement | contactid | contact_entitlement_ContactId | 
| entitlement | customerid | contact_entitlement_Customer | 
| customeropportunityrole | customerid | contact_customer_opportunity_roles | 
| invoice | customerid | invoice_customer_contacts | 
| opportunity | customerid | opportunity_customer_contacts | 
| salesorder | customerid | order_customer_contacts | 
| quote | customerid | quote_customer_contacts | 
| opportunity | parentcontactid | opportunity_parent_contact | 
| msdyn_playbookinstance | regarding | msdyn_playbookinstance_contact | 
| sharepointdocumentlocation | regardingobjectid | contact_SharePointDocumentLocations | 
| sharepointdocument | regardingobjectid | contact_SharePointDocuments | 
| msfp_alert | regardingobjectid | contact_msfp_alerts | 
| msfp_surveyinvite | regardingobjectid | contact_msfp_surveyinvites | 
| msfp_surveyresponse | regardingobjectid | contact_msfp_surveyresponses | 
| msdyn_bookingalert | regardingobjectid | contact_msdyn_bookingalerts | 
| msdyn_actual | msdyn_contactcustomer | msdyn_contact_msdyn_actual_ContactCustomer | 
| msdyn_actual | msdyn_contactvendor | msdyn_contact_msdyn_actual_ContactVendor | 
| adx_webpage | adx_authorid | adx_contact_webpage | 
| incident | msa_partnercontactid | msa_contact_incident | 
| opportunity | msa_partneroppid | msa_contact_opportunity | 
| adx_alertsubscription | regardingobjectid | contact_adx_alertsubscriptions | 
| adx_inviteredemption | regardingobjectid | contact_adx_inviteredemptions | 
| adx_webpagehistory | adx_changedbyid | adx_changedcontact_webpagehistory | 
| adx_pagenotification | adx_recipient | adx_contact_pagenotification | 
| adx_pollsubmission | adx_contactid | adx_contact_pollsubmission | 
| adx_webfilelog | adx_contactid | adx_contact_webfilelog | 
| adx_webpagelog | adx_contactid | adx_contact_webpagelog | 
| adx_invitation | adx_invitecontact | adx_invitation_invitecontact | 
| adx_invitation | adx_invitercontact | adx_invitation_invitercontact | 
| adx_invitation | adx_redeemedcontact | adx_invitation_redeemedContact | 
| adx_pagealert | adx_subscriberid | adx_subscribercontact_pagealert | 
| adx_externalidentity | adx_contactid | adx_contact_externalidentity | 
| adx_bpf_c2857b638fa7473d8e2f112c232cebd8 | bpf_contactid | bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8 | 
| adx_webformsession | adx_contact | adx_webformsession_contact | 
| adx_portalcomment | regardingobjectid | contact_adx_portalcomments | 
| post | regardingobjectid | contact_Posts | 


 

### Many to relationships

| Primary entity | Foreign key | Schema name | 
|---|---|---|
| principalobjectattributeaccess | objectid | contact_principalobjectattributeaccess | 
| slakpiinstance | regarding | slakpiinstance_contact | 
| socialactivity | postauthoraccount | socialactivity_postauthoraccount_contacts | 
| email | emailsender | Contact_Email_EmailSender | 
| task | regardingobjectid | Contact_Tasks | 
| postfollow | regardingobjectid | contact_PostFollows | 
| postrole | regardingobjectid | contact_PostRoles | 
| postregarding | regardingobjectid | contact_PostRegardings | 
| recurringappointmentmaster | regardingobjectid | Contact_RecurringAppointmentMasters | 
| contact | masterid | contact_master_contact | 
| customerrelationship | partnerid | contact_customer_relationship_partner | 
| feedback | createdbycontact | lk_contact_feedback_createdby | 
| actioncard | regardingobjectid | contact_actioncard | 
| connection | record2id | contact_connections2 | 
| bulkdeletefailure | regardingobjectid | Contact_BulkDeleteFailures | 
| activityparty | partyid | contact_activity_parties | 
| duplicaterecord | baserecordid | Contact_DuplicateBaseRecord | 
| annotation | objectid | Contact_Annotation | 
| socialactivity | regardingobjectid | Contact_SocialActivities | 
| activitypointer | regardingobjectid | Contact_ActivityPointers | 
| mailboxtrackingfolder | regardingobjectid | Contact_MailboxTrackingFolder | 
| account | primarycontactid | account_primary_contact | 
| socialprofile | customerid | Socialprofile_customer_contacts | 
| externalpartyitem | regardingobjectid | Contact_ExternalPartyItems | 
| socialactivity | postauthor | socialactivity_postauthor_contacts | 
| feedback | createdonbehalfbycontact | lk_contact_feedback_createdonbehalfby | 
| email | regardingobjectid | Contact_Emails | 
| appointment | regardingobjectid | Contact_Appointments | 
| feedback | regardingobjectid | Contact_Feedback | 
| processsession | regardingobjectid | Contact_ProcessSessions | 
| asyncoperation | regardingobjectid | Contact_AsyncOperations | 
| connection | record1id | contact_connections1 | 
| customeraddress | parentid | Contact_CustomerAddress | 
| phonecall | regardingobjectid | Contact_Phonecalls | 
| contact | parentcustomerid | contact_customer_contacts | 
| userentityinstancedata | objectid | userentityinstancedata_contact | 
| syncerror | regardingobjectid | Contact_SyncErrors | 
| duplicaterecord | duplicaterecordid | Contact_DuplicateMatchingRecord | 
| customerrelationship | customerid | contact_customer_relationship_customer | 
| fax | regardingobjectid | Contact_Faxes | 
| letter | regardingobjectid | Contact_Letters | 
| lead | customerid | lead_customer_contacts | 
| lead | parentcontactid | lead_parent_contact | 
| bookableresource | contactid | contact_bookableresource_ContactId | 
| bulkoperation | regardingobjectid | contact_BulkOperations | 
| campaignresponse | regardingobjectid | contact_CampaignResponses | 
| bulkoperationlog | createdobjectid | CreatedContact_BulkOperationLogs | 
| bulkoperationlog | regardingobjectid | SourceContact_BulkOperationLogs | 
| serviceappointment | regardingobjectid | Contact_ServiceAppointments | 
| incident | responsiblecontactid | contact_as_responsible_contact | 
| contractdetail | customerid | contractlineitem_customer_contacts | 
| contract | billingcustomerid | contract_billingcustomer_contacts | 
| contract | customerid | contract_customer_contacts | 
| incident | customerid | incident_customer_contacts | 
| incident | primarycontactid | contact_as_primary_contact | 
| entitlement | contactid | contact_entitlement_ContactId | 
| entitlement | customerid | contact_entitlement_Customer | 
| customeropportunityrole | customerid | contact_customer_opportunity_roles | 
| invoice | customerid | invoice_customer_contacts | 
| opportunity | customerid | opportunity_customer_contacts | 
| salesorder | customerid | order_customer_contacts | 
| quote | customerid | quote_customer_contacts | 
| opportunity | parentcontactid | opportunity_parent_contact | 
| msdyn_playbookinstance | regarding | msdyn_playbookinstance_contact | 
| sharepointdocumentlocation | regardingobjectid | contact_SharePointDocumentLocations | 
| sharepointdocument | regardingobjectid | contact_SharePointDocuments | 
| msfp_alert | regardingobjectid | contact_msfp_alerts | 
| msfp_surveyinvite | regardingobjectid | contact_msfp_surveyinvites | 
| msfp_surveyresponse | regardingobjectid | contact_msfp_surveyresponses | 
| msdyn_bookingalert | regardingobjectid | contact_msdyn_bookingalerts | 
| msdyn_actual | msdyn_contactcustomer | msdyn_contact_msdyn_actual_ContactCustomer | 
| msdyn_actual | msdyn_contactvendor | msdyn_contact_msdyn_actual_ContactVendor | 
| adx_webpage | adx_authorid | adx_contact_webpage | 
| incident | msa_partnercontactid | msa_contact_incident | 
| opportunity | msa_partneroppid | msa_contact_opportunity | 
| adx_alertsubscription | regardingobjectid | contact_adx_alertsubscriptions | 
| adx_inviteredemption | regardingobjectid | contact_adx_inviteredemptions | 
| adx_webpagehistory | adx_changedbyid | adx_changedcontact_webpagehistory | 
| adx_pagenotification | adx_recipient | adx_contact_pagenotification | 
| adx_pollsubmission | adx_contactid | adx_contact_pollsubmission | 
| adx_webfilelog | adx_contactid | adx_contact_webfilelog | 
| adx_webpagelog | adx_contactid | adx_contact_webpagelog | 
| adx_invitation | adx_invitecontact | adx_invitation_invitecontact | 
| adx_invitation | adx_invitercontact | adx_invitation_invitercontact | 
| adx_invitation | adx_redeemedcontact | adx_invitation_redeemedContact | 
| adx_pagealert | adx_subscriberid | adx_subscribercontact_pagealert | 
| adx_externalidentity | adx_contactid | adx_contact_externalidentity | 
| adx_bpf_c2857b638fa7473d8e2f112c232cebd8 | bpf_contactid | bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8 | 
| adx_webformsession | adx_contact | adx_webformsession_contact | 
| adx_portalcomment | regardingobjectid | contact_adx_portalcomments |
| post | regardingobjectid | contact_Posts | 

