IF OBJECT_ID(N'[__opensourcemigrationhistory]') IS NULL
BEGIN
    CREATE TABLE [__opensourcemigrationhistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___opensourcemigrationhistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [dbo].[BrandInformations] (
    [id] int NOT NULL IDENTITY,
    [brandname] nvarchar(100) NOT NULL,
    [registrationid] nvarchar(100) NOT NULL,
    [isActive] bit NOT NULL,
    [createddate] datetime2 NOT NULL,
    [modifieddate] datetime2 NOT NULL,
    CONSTRAINT [PK_BrandInformations] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[BrickCategories] (
    [id] int NOT NULL IDENTITY,
    [brick_id] nvarchar(100) NULL,
    [brick] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_BrickCategories] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[CompanySectorCategories] (
    [id] int NOT NULL IDENTITY,
    [sectorcategory] nvarchar(max) NULL,
    [sectorcode] nvarchar(max) NULL,
    CONSTRAINT [PK_CompanySectorCategories] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[CompanySectorTypes] (
    [id] int NOT NULL IDENTITY,
    [sectortype] nvarchar(max) NULL,
    CONSTRAINT [PK_CompanySectorTypes] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[Countries] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(max) NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[GCPInformations] (
    [ID] int NOT NULL IDENTITY,
    [RegistrationID] nvarchar(max) NULL,
    [CompanyPrefix] nvarchar(max) NULL,
    [AssignBy] nvarchar(max) NULL,
    [GtinCount] int NOT NULL,
    [MaxGtin] int NOT NULL,
    [Active] bit NOT NULL,
    [IsEmailSent] bit NOT NULL,
    [DateOfIssuance] datetime2 NOT NULL,
    [CreatedOn] datetimeoffset NOT NULL,
    [UpdatedOn] datetimeoffset NOT NULL,
    CONSTRAINT [PK_GCPInformations] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [dbo].[GLNInformations] (
    [id] int NOT NULL IDENTITY,
    [registrationid] nvarchar(50) NOT NULL,
    [glnrequestid] int NOT NULL,
    [gln] nvarchar(50) NOT NULL,
    [companyprefix] nvarchar(50) NULL,
    [asignedby] nvarchar(max) NULL,
    [createddate] datetime2 NOT NULL,
    [modifieddate] datetime2 NULL,
    CONSTRAINT [PK_GLNInformations] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[GTINFees] (
    [ID] int NOT NULL IDENTITY,
    [Description] nvarchar(200) NOT NULL,
    [RenewalFee] float NOT NULL,
    [Price] float NOT NULL,
    [NumberOfGtins] int NOT NULL,
    [AdditionalFee] float NOT NULL,
    CONSTRAINT [PK_GTINFees] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [dbo].[GTINInformations] (
    [id] int NOT NULL IDENTITY,
    [registrationid] nvarchar(50) NOT NULL,
    [gtin] nvarchar(50) NOT NULL,
    [companyprefix] nvarchar(50) NULL,
    [productcode] nvarchar(50) NULL,
    [checksum] nvarchar(max) NULL,
    [createddate] datetime2 NOT NULL,
    [modifieddate] datetime2 NULL,
    CONSTRAINT [PK_GTINInformations] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[HeardAboutUs] (
    [id] int NOT NULL IDENTITY,
    [method] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_HeardAboutUs] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[ImageBanks] (
    [id] int NOT NULL IDENTITY,
    [registrationid] nvarchar(100) NOT NULL,
    [imageReserve] int NOT NULL,
    [createdOn] datetime2 NOT NULL,
    [lastModified] datetime2 NOT NULL,
    CONSTRAINT [PK_ImageBanks] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[ImageRequests] (
    [id] int NOT NULL IDENTITY,
    [imagetype] nvarchar(10) NOT NULL,
    [registrationid] nvarchar(20) NOT NULL,
    [imagecount] int NOT NULL,
    [isapproved] bit NOT NULL,
    [approvedby] nvarchar(50) NULL,
    [requestedate] datetime2 NOT NULL,
    [createdon] datetime2 NOT NULL,
    [updatedon] datetime2 NOT NULL,
    CONSTRAINT [PK_ImageRequests] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[ITFInformations] (
    [id] int NOT NULL IDENTITY,
    [registrationid] nvarchar(50) NOT NULL,
    [itf14] nvarchar(50) NOT NULL,
    [companyprefix] nvarchar(50) NULL,
    [createddate] datetime2 NOT NULL,
    [modifieddate] datetime2 NULL,
    CONSTRAINT [PK_ITFInformations] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[NetContents] (
    [id] int NOT NULL IDENTITY,
    [code] nvarchar(max) NOT NULL,
    [name] nvarchar(200) NOT NULL,
    [description] nvarchar(500) NULL,
    CONSTRAINT [PK_NetContents] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[PackageLevels] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(100) NOT NULL,
    [description] nvarchar(max) NULL,
    CONSTRAINT [PK_PackageLevels] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[PackagingTypes] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_PackagingTypes] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[Roles] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(max) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[SegmentCategories] (
    [ID] int NOT NULL IDENTITY,
    [SegmentCode] int NOT NULL,
    [SegmentTitle] nvarchar(500) NOT NULL,
    [SegmentDefinition] nvarchar(max) NULL,
    CONSTRAINT [PK_SegmentCategories] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [dbo].[TargetMarkets] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(200) NOT NULL,
    CONSTRAINT [PK_TargetMarkets] PRIMARY KEY ([id])
);
GO

CREATE TABLE [dbo].[States] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(max) NULL,
    [country_id] int NOT NULL,
    CONSTRAINT [PK_States] PRIMARY KEY ([id]),
    CONSTRAINT [FK_States_Countries_country_id] FOREIGN KEY ([country_id]) REFERENCES [dbo].[Countries] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[GTINRequests] (
    [id] int NOT NULL IDENTITY,
    [company_id] int NOT NULL,
    [registrationid] nvarchar(max) NOT NULL,
    [gtinfee_id] int NOT NULL,
    [gtincount] int NOT NULL,
    [totalcost] float NOT NULL,
    [dateofrequest] datetime2 NOT NULL,
    [isapproved] bit NOT NULL,
    [approvedby] nvarchar(100) NULL,
    [approvaldate] datetime2 NULL,
    [isgcpassigned] bit NOT NULL,
    [assigneddate] datetime2 NULL,
    [assignedby] nvarchar(100) NULL,
    [requesttype] nvarchar(100) NULL,
    [imagerequest_id] int NULL,
    [createdon] datetime2 NOT NULL,
    [updatedon] datetime2 NULL,
    CONSTRAINT [PK_GTINRequests] PRIMARY KEY ([id]),
    CONSTRAINT [FK_GTINRequests_Companies_company_id] FOREIGN KEY ([company_id]) REFERENCES [dbo].[Companies] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_GTINRequests_GTINFees_gtinfee_id] FOREIGN KEY ([gtinfee_id]) REFERENCES [dbo].[GTINFees] ([ID]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[ContactInformations] (
    [id] int NOT NULL IDENTITY,
    [company_id] int NOT NULL,
    [billingname] nvarchar(200) NULL,
    [billingemail] nvarchar(200) NULL,
    [billingdesignation] nvarchar(200) NULL,
    [billingphonenumber] nvarchar(200) NULL,
    [ceoemail] nvarchar(200) NULL,
    [ceoname] nvarchar(200) NULL,
    [ceodesignation] nvarchar(200) NULL,
    [ceophonenumber] nvarchar(200) NULL,
    [contactperson] nvarchar(200) NULL,
    [contactemail] nvarchar(200) NULL,
    [contactphonenumber] nvarchar(200) NULL,
    [salename] nvarchar(200) NULL,
    [saleemail] nvarchar(200) NULL,
    [salephonenumber] nvarchar(200) NULL,
    [salesdesignation] nvarchar(200) NULL,
    [reasonforapplying] nvarchar(300) NULL,
    [createdon] datetime2 NOT NULL,
    [modifiedon] datetime2 NOT NULL,
    [heardaboutus_id] int NULL,
    [registrationId] nvarchar(20) NULL,
    CONSTRAINT [PK_ContactInformations] PRIMARY KEY ([id]),
    CONSTRAINT [FK_ContactInformations_HeardAboutUs_heardaboutus_id] FOREIGN KEY ([heardaboutus_id]) REFERENCES [dbo].[HeardAboutUs] ([id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [dbo].[Products] (
    [id] int NOT NULL IDENTITY,
    [gtin] nvarchar(50) NOT NULL,
    [registrationid] nvarchar(100) NOT NULL,
    [netcontent_id] int NULL,
    [brandname] nvarchar(200) NOT NULL,
    [brandinformation_id] int NULL,
    [packagingtype_id] int NULL,
    [productdescription] nvarchar(max) NULL,
    [marketingmessage] nvarchar(max) NULL,
    [targetmarket_id] nvarchar(max) NULL,
    [consumerfirstavailabilitydate] datetime2 NOT NULL,
    [netweight] float NOT NULL,
    [iscompleted] bit NOT NULL,
    [grossweight] float NOT NULL,
    [brickcategory_id] int NULL,
    [frontimage] nvarchar(500) NULL,
    [hasimage] bit NOT NULL,
    [backimage] nvarchar(500) NULL,
    [leftimage] nvarchar(500) NULL,
    [rightimage] nvarchar(500) NULL,
    [otherimage] nvarchar(500) NULL,
    [dateoflisting] datetime2 NOT NULL,
    [ingredients] nvarchar(max) NULL,
    [allergeninfo] nvarchar(500) NULL,
    [nafdacnumber] nvarchar(100) NULL,
    [storageinstruction] nvarchar(max) NULL,
    [directionofuse] nvarchar(max) NULL,
    [lifespan] int NOT NULL,
    [lifespanunit] nvarchar(500) NULL,
    [packaginglevel_id] int NULL,
    [createddate] datetime2 NOT NULL,
    [modifieddate] datetime2 NOT NULL,
    [IsPharma] bit NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Products_BrandInformations_brandinformation_id] FOREIGN KEY ([brandinformation_id]) REFERENCES [dbo].[BrandInformations] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_BrickCategories_brickcategory_id] FOREIGN KEY ([brickcategory_id]) REFERENCES [dbo].[BrickCategories] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_NetContents_netcontent_id] FOREIGN KEY ([netcontent_id]) REFERENCES [dbo].[NetContents] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_PackageLevels_packaginglevel_id] FOREIGN KEY ([packaginglevel_id]) REFERENCES [dbo].[PackageLevels] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_PackagingTypes_packagingtype_id] FOREIGN KEY ([packagingtype_id]) REFERENCES [dbo].[PackagingTypes] ([id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [dbo].[Users] (
    [id] int NOT NULL IDENTITY,
    [company_id] int NOT NULL,
    [email] nvarchar(max) NULL,
    [password] nvarchar(max) NULL,
    [registrationid] nvarchar(max) NULL,
    [role_id] int NOT NULL,
    [active] bit NOT NULL,
    [firstname] nvarchar(max) NULL,
    [lastname] nvarchar(max) NULL,
    [createdon] datetime2 NOT NULL,
    [updatedon] datetime2 NOT NULL,
    [Companiesid] int NULL,
    [Rolesid] int NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Users_Companies_Companiesid] FOREIGN KEY ([Companiesid]) REFERENCES [dbo].[Companies] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Users_Roles_Rolesid] FOREIGN KEY ([Rolesid]) REFERENCES [dbo].[Roles] ([id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [dbo].[FamilyCategories] (
    [ID] int NOT NULL IDENTITY,
    [FamilyCode] int NOT NULL,
    [SegmentCode] int NOT NULL,
    [FamilyTitle] nvarchar(500) NOT NULL,
    [FamilyDefinition] nvarchar(max) NULL,
    CONSTRAINT [PK_FamilyCategories] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_FamilyCategories_SegmentCategories_SegmentCode] FOREIGN KEY ([SegmentCode]) REFERENCES [dbo].[SegmentCategories] ([ID]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[LocalGovts] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(max) NULL,
    [state_id] int NOT NULL,
    CONSTRAINT [PK_LocalGovts] PRIMARY KEY ([id]),
    CONSTRAINT [FK_LocalGovts_States_state_id] FOREIGN KEY ([state_id]) REFERENCES [dbo].[States] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[ExternalUnifiedModels] (
    [id] int NOT NULL IDENTITY,
    [product_id] int NOT NULL,
    [functionalname] nvarchar(255) NULL,
    [genericname] nvarchar(255) NULL,
    [tradeitemdescription] nvarchar(255) NULL,
    [strength] nvarchar(255) NULL,
    [productform] nvarchar(255) NULL,
    [routeofadministration] nvarchar(255) NULL,
    [shelflife] nvarchar(255) NULL,
    [atccode] nvarchar(255) NULL,
    [packsize] nvarchar(255) NULL,
    [quantity] nvarchar(255) NULL,
    [unitofmeasure] nvarchar(255) NULL,
    [primarypackagingmaterial] nvarchar(255) NULL,
    [labeldescription] nvarchar(255) NULL,
    [datecreated] datetime2 NOT NULL,
    [createdby] nvarchar(max) NULL,
    [datemodified] datetime2 NOT NULL,
    [modifiedby] nvarchar(max) NULL,
    CONSTRAINT [PK_ExternalUnifiedModels] PRIMARY KEY ([id]),
    CONSTRAINT [FK_ExternalUnifiedModels_Products_product_id] FOREIGN KEY ([product_id]) REFERENCES [dbo].[Products] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[PharmaceuticalInformations] (
    [ID] int NOT NULL IDENTITY,
    [GenericName] nvarchar(max) NULL,
    [FunctionalName] nvarchar(max) NULL,
    [TradeItemDescription] nvarchar(max) NULL,
    [Strength] nvarchar(max) NULL,
    [ShelfLife] nvarchar(max) NULL,
    [ProductForm] nvarchar(max) NULL,
    [RouteOfAdministration] nvarchar(max) NULL,
    [ATCCode] nvarchar(max) NULL,
    [PackSize] nvarchar(max) NULL,
    [Quantity] nvarchar(max) NULL,
    [ActiveIngredient] nvarchar(max) NULL,
    [PrimaryPackagingMaterial] nvarchar(max) NULL,
    [DirectionOfUse] nvarchar(max) NULL,
    [Manufacturer] nvarchar(max) NULL,
    [ManufacturerAddress] nvarchar(max) NULL,
    [ProductID] int NOT NULL,
    CONSTRAINT [PK_PharmaceuticalInformations] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_PharmaceuticalInformations_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[ProductTargetMarkets] (
    [id] int NOT NULL IDENTITY,
    [product_id] int NOT NULL,
    [targetmarket_id] int NOT NULL,
    [registrationid] nvarchar(max) NULL,
    [datecreated] datetime2 NOT NULL,
    CONSTRAINT [PK_ProductTargetMarkets] PRIMARY KEY ([id], [product_id], [targetmarket_id]),
    CONSTRAINT [FK_ProductTargetMarkets_Products_product_id] FOREIGN KEY ([product_id]) REFERENCES [dbo].[Products] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ProductTargetMarkets_TargetMarkets_targetmarket_id] FOREIGN KEY ([targetmarket_id]) REFERENCES [dbo].[TargetMarkets] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[UserValidationTokens] (
    [id] int NOT NULL IDENTITY,
    [user_id] int NOT NULL,
    [subvalidationtoken] nvarchar(max) NULL,
    [isactive] bit NOT NULL,
    [ipaddress] nvarchar(max) NULL,
    [expirationDate] datetime2 NOT NULL,
    [datecreated] datetimeoffset NOT NULL,
    [datemodified] datetimeoffset NOT NULL,
    [Userid] int NULL,
    CONSTRAINT [PK_UserValidationTokens] PRIMARY KEY ([id]),
    CONSTRAINT [FK_UserValidationTokens_Users_Userid] FOREIGN KEY ([Userid]) REFERENCES [dbo].[Users] ([id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [dbo].[ClassCategories] (
    [ID] int NOT NULL IDENTITY,
    [ClassCode] int NOT NULL,
    [FamilyCode] int NOT NULL,
    [ClassTitle] nvarchar(500) NOT NULL,
    [ClassDefinition] nvarchar(max) NULL,
    CONSTRAINT [PK_ClassCategories] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_ClassCategories_FamilyCategories_FamilyCode] FOREIGN KEY ([FamilyCode]) REFERENCES [dbo].[FamilyCategories] ([ID]) ON DELETE CASCADE
);
GO

CREATE TABLE [dbo].[Companies] (
    [id] int NOT NULL IDENTITY,
    [companyname] nvarchar(300) NOT NULL,
    [email] nvarchar(200) NULL,
    [phonenumber] nvarchar(20) NULL,
    [country_id] int NOT NULL,
    [state_id] int NULL,
    [localgovt_id] int NULL,
    [registrationid] nvarchar(20) NOT NULL,
    [companyaddress] nvarchar(500) NULL,
    [factoryaddress] nvarchar(500) NULL,
    [registrationdate] datetime2 NULL,
    [dateofincorporation] datetime2 NULL,
    [cacnumber] nvarchar(20) NULL,
    [websiteaddress] nvarchar(500) NULL,
    [isregistrationcompleted] bit NOT NULL,
    [facebookaccount] nvarchar(200) NULL,
    [twitteraccount] nvarchar(200) NULL,
    [instagramaccount] nvarchar(200) NULL,
    [numberofstaff] int NOT NULL,
    [sectortype_id] int NULL,
    [sectorcategory_id] int NULL,
    [approvalstatus] bit NOT NULL,
    [createdon] datetime2 NOT NULL,
    [modifiedon] datetime2 NOT NULL,
    [ApprovedBy] nvarchar(max) NULL,
    [DateOfApproval] datetime2 NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Companies_CompanySectorCategories_sectorcategory_id] FOREIGN KEY ([sectorcategory_id]) REFERENCES [dbo].[CompanySectorCategories] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Companies_CompanySectorTypes_sectortype_id] FOREIGN KEY ([sectortype_id]) REFERENCES [dbo].[CompanySectorTypes] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Companies_Countries_country_id] FOREIGN KEY ([country_id]) REFERENCES [dbo].[Countries] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Companies_LocalGovts_localgovt_id] FOREIGN KEY ([localgovt_id]) REFERENCES [dbo].[LocalGovts] ([id]) ON DELETE NO ACTION
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1, N'Airbrushes (Powered)', N'10001686'),
(2292, N'Nephrolepis Exaltata – Live Plants', N'10006668'),
(2293, N'Nolina Recurvata – Live Plants', N'10006669'),
(2294, N'Nymphaea – Live Plants', N'10006670'),
(2295, N'Oncidium – Live Plants', N'10006671'),
(2296, N'Orchis – Live Plants', N'10006672'),
(2297, N'Ornithogalum Thyrsoides – Live Plants', N'10006673'),
(2298, N'Osteospermum – Live Plants', N'10006674'),
(2299, N'Pachira Aquatica – Live Plants', N'10006681'),
(2300, N'Paeonia – Live Plants', N'10006682'),
(2301, N'Papaver Nudicaule – Live Plants', N'10006683'),
(2291, N'Narcissus – Live Plants', N'10006667'),
(2302, N'Paphiopedilum – Live Plants', N'10006684'),
(2304, N'Pennisetum – Live Plants', N'10006686'),
(2305, N'Petunia – Live Plants', N'10006687'),
(2306, N'Phalaenopsis – Live Plants', N'10006688'),
(2307, N'Phlox – Live Plants', N'10006689'),
(2308, N'Phoenix Roebelenii – Live Plants', N'10006690'),
(2309, N'Platycodon Grandiflorus – Live Plants', N'10006691'),
(2310, N'Plectranthus – Live Plants', N'10006692'),
(2311, N'Portulaca – Live Plants', N'10006693'),
(2312, N'Primula – Live Plants', N'10006694'),
(2313, N'Ranunculus – Live Plants', N'10006695'),
(2303, N'Pelargonium – Live Plants', N'10006685'),
(2290, N'Myosotis Sylvatica – Live Plants', N'10006666'),
(2289, N'Muscari – Live Plants', N'10006665'),
(2288, N'Miltonia – Live Plants', N'10006664'),
(2265, N'Hyacinthus Orientalis – Live Plants', N'10006647'),
(2266, N'Hydrangea Macrophylla – Live Plants', N'10006648'),
(2267, N'Impatiens – Live Plants', N'10006649'),
(2268, N'Jasminum Polyanthum – Live Plants', N'10006650'),
(2269, N'Kalanchoe Blossfeldiana – Live Plants', N'10006651'),
(2270, N'Lantana Camara – Live Plants', N'10006652'),
(2271, N'Leucanthemum – Live Plants', N'10006653'),
(2272, N'Lewisia Cotyledon – Live Plants', N'10006654'),
(2273, N'Lilium – Live Plants', N'10006655'),
(2274, N'Lithodora Diffusa – Live Plants', N'10006656'),
(2275, N'Live Plant Variety Packs', N'10006657'),
(2276, N'Ferns – Live Plants Other', N'10006676'),
(2277, N'Grasses – Live Plants Other', N'10006677'),
(2278, N'Herbs – Live Plants Other', N'10006678'),
(2279, N'Live Plants Other', N'10006679');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2280, N'Succulents/Cacti – Live Plants Other', N'10006675'),
(2281, N'Water Plants – Live Plants Other', N'10006680'),
(2282, N'Livistona Rotundifolia – Live Plants', N'10006658'),
(2283, N'Lobelia Erinus – Live Plants', N'10006659'),
(2284, N'Lotus Corniculatus – Live Plants', N'10006660'),
(2285, N'Lupinus – Live Plants', N'10006661'),
(2286, N'Mandevilla – Live Plants', N'10006662'),
(2287, N'Medinilla Magnifica – Live Plants', N'10006663'),
(2314, N'Rhipsalidopsis – Live Plants', N'10006696'),
(2315, N'Rhododendron – Live Plants', N'10006697'),
(2316, N'Rosa – Live Plants', N'10006726'),
(2317, N'Saintpaulia – Live Plants', N'10006698'),
(2345, N'Seedlings - Ready to Grow', N'10006774'),
(2346, N'Seeds/Spores', N'10003291'),
(2347, N'Shrubs/Trees', N'10003714'),
(2348, N'Vegetables/Fungi', N'10003852'),
(2349, N'Baby Bath Safety Products', N'10000498'),
(2350, N'Baby Baths/Bath Chairs/Bath Cradles', N'10000827'),
(2351, N'Baby Changing Mats', N'10000822'),
(2352, N'Baby Changing Table', N'10000501'),
(2353, N'Baby Potties/Training Seats', N'10000821'),
(2354, N'Baby Sanitary Furnishings - Other', N'10006797'),
(2355, N'Baby Sanitary Furnishings Variety Pack', N'10006795'),
(2356, N'Baby Cot Mattress', N'10000790'),
(2357, N'Baby Cots/Cot Beds/Bassinet', N'10000789'),
(2358, N'Household Baby Beds/Mattresses - Other', N'10006808'),
(2359, N'Household Baby Beds/Mattresses Variety Pack', N'10006806'),
(2360, N'Baby Bouncing Cradles/Rocker Seats (Powered)', N'10000801'),
(2361, N'Baby High Chair', N'10000787'),
(2362, N'Household Baby Seating - Other', N'10006811'),
(2363, N'Household Baby Seating Variety Pack', N'10006809'),
(2364, N'Bed Sheets/Valances', N'10002227'),
(2365, N'Bedding Other', N'10002230'),
(2366, N'Blankets (Powered)', N'10005197'),
(2367, N'Blankets/Throws (Non Powered)', N'10002224'),
(2344, N'Plants Variety Packs', N'10003305'),
(2264, N'Howea Forsteriana – Live Plants', N'10006646'),
(2343, N'Zantedeschia – Live Plants', N'10006725'),
(2341, N'Yucca – Live Plants', N'10006723'),
(2318, N'Salvia Nemorosa – Live Plants', N'10006699'),
(2319, N'Sansevieria Cylindrica – Live Plants', N'10006700'),
(2320, N'Sanvitalia Procumbens – Live Plants', N'10006701');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2321, N'Saxifraga – Live Plants', N'10006703'),
(2322, N'Schefflera Arboricola – Live Plants', N'10006704'),
(2323, N'Schlumbergera – Live Plants', N'10006705'),
(2324, N'Sedum – Live Plants', N'10006706'),
(2325, N'Sempervivum – Live Plants', N'10006707'),
(2326, N'Senecio Maritima – Live Plants', N'10006708'),
(2327, N'Sinningia – Live Plants', N'10006709'),
(2328, N'Solanum Rantonnetii – Live Plants', N'10006710'),
(2329, N'Spathiphyllum – Live Plants', N'10006711'),
(2330, N'Stephanotis Floribunda – Live Plants', N'10006712'),
(2331, N'Sutera Cordata – Live Plants', N'10006713'),
(2332, N'Tagetes – Live Plants', N'10006714'),
(2333, N'Tillandsia Cyanea – Live Plants', N'10006715'),
(2334, N'Tulipa – Live Plants', N'10006716'),
(2335, N'Vanda – Live Plants', N'10006717'),
(2336, N'Verbena – Live Plants', N'10006718'),
(2337, N'Viola – Live Plants', N'10006719'),
(2338, N'Vriesea – Live Plants', N'10006720'),
(2339, N'Xburrageara – Live Plants', N'10006721'),
(2340, N'Xcitrofortunella Microcarpa – Live Plants', N'10006722'),
(2342, N'Zamioculcas Zamiifolia – Live Plants', N'10006724'),
(2263, N'Hosta – Live Plants', N'10006645'),
(2262, N'Hordeum – Live Plants', N'10006644'),
(2261, N'Hippeastrum – Live Plants', N'10006643'),
(2184, N'Aloe – Live Plants', N'10006566'),
(2185, N'Alstroemeria – Live Plants', N'10006567'),
(2186, N'Anemone Hupehensis – Live Plants', N'10006568'),
(2187, N'Angelonia – Live Plants', N'10006569'),
(2188, N'Anisodontea Capensis – Live Plants', N'10006570'),
(2189, N'Anthurium – Live Plants', N'10006571'),
(2190, N'Antirrhinum Majus – Live Plants', N'10006572'),
(2191, N'Argyranthemum Frutescens – Live Plants', N'10006573'),
(2192, N'Armeria Maritima – Live Plants', N'10006574'),
(2193, N'Aster – Live Plants', N'10006575'),
(2194, N'Astilbe – Live Plants', N'10006576'),
(2195, N'Aubrieta Gracilis – Live Plants', N'10006577'),
(2196, N'Begonia – Live Plants', N'10006578'),
(2197, N'Bellis Perennis – Live Plants', N'10006579'),
(2198, N'Bidens – Live Plants', N'10006580'),
(2199, N'Bougainvillea – Live Plants', N'10006581'),
(2200, N'Brachyscome Multifida – Live Plants', N'10006582'),
(2201, N'Brassica – Live Plants', N'10006583');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2202, N'Bromelia – Live Plants', N'10006584'),
(2203, N'Brugmansia – Live Plants', N'10006585'),
(2204, N'Calathea – Live Plants', N'10006586'),
(2205, N'Calibrachoa – Live Plants', N'10006587'),
(2206, N'Calocephalus Brownii – Live Plants', N'10006588'),
(2183, N'Alocasia – Live Plants', N'10006565'),
(2207, N'Campanula Portenschlagiana – Live Plants', N'10006589'),
(2182, N'Agapanthus – Live Plants', N'10006564'),
(2180, N'Aechmea – Live Plants', N'10006562'),
(2157, N'Eupatorium Rugosum – Cut Greens', N'10006538'),
(2158, N'Fatsia Japonica – Cut Greens', N'10006539'),
(2159, N'Gomphocarpus Fruticosus – Cut Greens', N'10006540'),
(2160, N'Hydrangea Macrophylla – Cut Greens', N'10006541'),
(2161, N'Ilex Verticillata – Cut Greens', N'10006542'),
(2162, N'Leucadendron – Cut Greens', N'10006543'),
(2163, N'Lilium – Cut Greens', N'10006544'),
(2164, N'Matthiola Incana – Cut Greens', N'10006545'),
(2165, N'Monstera – Cut Greens', N'10006546'),
(2166, N'Panicum – Cut Greens', N'10006548'),
(2167, N'Physalis Alkekengi – Cut Greens', N'10006549'),
(2168, N'Pittosporum – Cut Greens', N'10006550'),
(2169, N'Quercus Rubra – Cut Greens', N'10006551'),
(2170, N'Rosa Rose/Hip – Cut Greens', N'10006552'),
(2171, N'Ruscus Hypophyllum – Cut Greens', N'10006553'),
(2172, N'Salix – Cut Greens', N'10006554'),
(2173, N'Setaria Italica – Cut Greens', N'10006555'),
(2174, N'Strelitzia Reginae – Cut Greens', N'10006556'),
(2175, N'Symphoricarpos – Cut Greens', N'10006557'),
(2176, N'Syringa Vulgaris – Cut Greens', N'10006558'),
(2177, N'Thlaspi – Cut Greens', N'10006559'),
(2178, N'Viburnum Opulus – Cut Greens', N'10006560'),
(2179, N'Zantedeschia Aethiopica – Cut Greens', N'10006561'),
(2181, N'Aeonium Arboreum – Live Plants', N'10006563'),
(2368, N'Duvet Covers', N'10002223'),
(2208, N'Canna – Live Plants', N'10006590'),
(2210, N'Chamaedorea Elegans – Live Plants', N'10006592'),
(2238, N'Epipremnum Pinnatum – Live Plants', N'10006620'),
(2239, N'Euphorbia Pulcherrima – Live Plants', N'10006621'),
(2240, N'Euryops – Live Plants', N'10006622'),
(2241, N'Fargesia Murieliae – Live Plants', N'10006623'),
(2242, N'Felicia Amelloides – Live Plants', N'10006624'),
(2243, N'Festuca Glauca – Live Plants', N'10006625');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2244, N'Ficus Benjamina – Live Plants', N'10006635'),
(2245, N'Fittonia – Live Plants', N'10006626'),
(2246, N'Fuchsia – Live Plants', N'10006627'),
(2247, N'Gardenia Jasminoides – Live Plants', N'10006628'),
(2248, N'Gaura Lindheimeri – Live Plants', N'10006629'),
(2249, N'Gazania – Live Plants', N'10006630'),
(2250, N'Gentiana – Live Plants', N'10006631'),
(2251, N'Gerbera – Live Plants', N'10006632'),
(2252, N'Guzmania – Live Plants', N'10006633'),
(2253, N'Gypsophila Muralis – Live Plants', N'10006634'),
(2254, N'Hedera Helix – Live Plants', N'10006636'),
(2255, N'Helianthus Annuus – Live Plants', N'10006637'),
(2256, N'Helichrysum Petiolare – Live Plants', N'10006638'),
(2257, N'Heliotropium – Live Plants', N'10006639'),
(2258, N'Helleborus Niger – Live Plants', N'10006640'),
(2259, N'Heuchera – Live Plants', N'10006641'),
(2260, N'Hibiscus Rosa-Sinensis – Live Plants', N'10006642'),
(2237, N'Echinacea Purpurea – Live Plants', N'10006619'),
(2209, N'Celosia – Live Plants', N'10006591'),
(2236, N'Echeveria – Live Plants', N'10006618'),
(2234, N'Dracaena Marginata – Live Plants', N'10006616'),
(2211, N'Chlorophytum Comosum – Live Plants', N'10006593'),
(2212, N'Chrysanthemum – Live Plants', N'10006594'),
(2213, N'Clivia Miniata – Live Plants', N'10006595'),
(2214, N'Cocos Nucifera – Live Plants', N'10006596'),
(2215, N'Codiaeum Variegatum – Live Plants', N'10006597'),
(2216, N'Cordyline Australis – Live Plants', N'10006598'),
(2217, N'Coreopsis Grandiflora – Live Plants', N'10006599'),
(2218, N'Cortaderia Selloana – Live Plants', N'10006600'),
(2219, N'Cosmos Bipinnatus – Live Plants', N'10006601'),
(2220, N'Cuphea Hyssopifolia – Live Plants', N'10006602'),
(2221, N'Cupressus Macrocarpa – Live Plants', N'10006603'),
(2222, N'Curcuma Alismatifolia – Live Plants', N'10006604'),
(2223, N'Cycas Revoluta – Live Plants', N'10006605'),
(2224, N'Cyclamen Persicum – Live Plants', N'10006606'),
(2225, N'Cymbidium – Live Plants', N'10006607'),
(2226, N'Cyperus Alternifolius – Live Plants', N'10006608'),
(2227, N'Dahlia – Live Plants', N'10006609'),
(2228, N'Delphinium – Live Plants', N'10006610'),
(2229, N'Dendrobium Nobile – Live Plants', N'10006611'),
(2230, N'Dianthus – Live Plants', N'10006612'),
(2231, N'Dicentra Spectabilis – Live Plants', N'10006613');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2232, N'Dieffenbachia – Live Plants', N'10006614'),
(2233, N'Dorotheanthus Bellidiformis – Live Plants', N'10006615'),
(2235, N'Dypsis Lutescens – Live Plants', N'10006617'),
(2156, N'Eucalyptus Cinerea – Cut Greens', N'10006537'),
(2369, N'Duvets/Quilts/Mattress Toppers', N'10002222'),
(2371, N'Pillow Cases', N'10002226'),
(2507, N'Mugs/Cups (Non Disposable)', N'10002155'),
(2508, N'Napkin Rings', N'10005210'),
(2509, N'Plates (Non Disposable)', N'10002153'),
(2510, N'Salt/Pepper Shakers', N'10005693'),
(2511, N'Salt/Pepper/Spice Mills (Non Powered)', N'10002163'),
(2512, N'Serving Jugs/Pitchers/Decanters', N'10002158'),
(2513, N'Serving Trays', N'10002159'),
(2514, N'Serving/Drinking Glasses', N'10002157'),
(2515, N'Serving/Eating/Drinking Tableware Other', N'10002167'),
(2516, N'Serving/Eating/Drinking Tableware Variety Packs', N'10002166'),
(2506, N'Ice/Wine Buckets', N'10002162'),
(2517, N'Table Covers - Non Fabric/Non Textile', N'10005202'),
(2519, N'Bottle/Can Insulators', N'10005470'),
(2520, N'Cappuccino Creamers (Non Powered)', N'10005435'),
(2521, N'Cocktail Shakers', N'10002132'),
(2522, N'Grinders/Juicers/Ice Crushers (Non Powered)', N'10002133'),
(2523, N'Household Water Testing Kits', N'10005208'),
(2524, N'Kettles (Non Powered)', N'10002129'),
(2525, N'Teapots/Cafetieres', N'10002131'),
(2526, N'Water Filters/Water Filter Cartridges', N'10002127'),
(2527, N'Water/Beverage Equipment Other', N'10002135'),
(2528, N'Animal Scarers/Deterrents (Lawn/Garden) - Non-Powered', N'10005362'),
(2518, N'Bottle Stoppers/Pourers', N'10002130'),
(2505, N'Food/Beverage Warmers (Non Powered)', N'10002161'),
(2504, N'Food Stands/Displays', N'10002165'),
(2503, N'Food Serving Trolleys (Non Powered)', N'10002160'),
(2480, N'Paper Filters', N'10000559'),
(2481, N'Rolling Pins', N'10002173'),
(2482, N'Sieves/Strainers/Colanders', N'10002146'),
(2483, N'Skewers/Sticks', N'10002174'),
(2484, N'Slicing/Chopping Boards', N'10002147'),
(2485, N'Spatulas/Scoops/Ladles', N'10002170'),
(2486, N'Tongs/Tweezers/Mallets/Mashers/Whisks', N'10002171'),
(2487, N'Beverage Decorations/Accessories (Non Edible)', N'10002128'),
(2488, N'Cake/Pastry Decorations/Accessories (Non Edible)', N'10002149'),
(2489, N'Food Shaping Moulds', N'10005430');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2490, N'Kitchen Merchandise Variety Packs', N'10002183'),
(2491, N'Disposable Food Bags', N'10000692'),
(2492, N'Disposable Food Wrap', N'10000693'),
(2493, N'Food/Beverage Storage Containers', N'10002122'),
(2494, N'Kitchen Storage – Replacement Parts/Accessories', N'10005209'),
(2495, N'Kitchen Storage Other', N'10002124'),
(2496, N'Kitchen Storage Racks/Stands/Holders/Dispensers', N'10002121'),
(2497, N'Kitchen Storage Variety Packs', N'10002123'),
(2498, N'String/Ties', N'10000541'),
(2499, N'Bowls (Non Disposable)', N'10002154'),
(2500, N'Cutlery (Non Disposable)', N'10002156'),
(2501, N'Disposable Tableware / Disposable Table Covers', N'10000635'),
(2502, N'Egg Cups', N'10005427'),
(2529, N'Animal Scarers/Deterrents (Lawn/Garden) – Powered', N'10006853'),
(2530, N'Fungicides', N'10004109'),
(2531, N'Lawn/Garden Chemicals/Treatments Other', N'10003240'),
(2532, N'Lawn/Garden Chemicals/Treatments Variety Packs', N'10003239'),
(2560, N'Electric Fence/Radio Fences', N'10003283'),
(2561, N'Fence Net/Mesh', N'10003281'),
(2562, N'Fence Panels/Boards', N'10003277'),
(2563, N'Fence Posts/Rails', N'10003278'),
(2564, N'Fence Stays/Braces', N'10003279'),
(2565, N'Garden Borders/Edges', N'10003280'),
(2566, N'Gates (Non Powered)', N'10003286'),
(2567, N'Gates (Powered)', N'10003287'),
(2568, N'Lawn/Garden Fencing Accessories', N'10005678'),
(2569, N'Lawn/Garden Fencing Other', N'10003289'),
(2570, N'Lawn/Garden Fencing Variety Packs', N'10003288'),
(2571, N'Razor/Barbed Wire Fencing', N'10003285'),
(2572, N'Trellising', N'10003284'),
(2573, N'Plant Supports/Stakes', N'10005220'),
(2574, N'Variety Planters – Box/Pot', N'10003854'),
(2575, N'Garden Benches', N'10003248'),
(2576, N'Garden Chairs', N'10003242'),
(2577, N'Garden Display Units', N'10003316'),
(2578, N'Garden Footrests', N'10003246'),
(2579, N'Garden Kneelers/Seats', N'10003406'),
(2580, N'Garden Loungers', N'10003243'),
(2581, N'Garden Ornaments/Plaques', N'10005719'),
(2582, N'Garden Swing Benches', N'10003249'),
(2559, N'Lawn/Garden Equipment Other', N'10003872'),
(2479, N'Openers – Kitchen', N'10002175');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2558, N'Lawn/Garden Equipment Accessories', N'10003352'),
(2556, N'Lawn Rollers (Non Powered)', N'10003394'),
(2533, N'Lawn/Garden Insecticides / Pesticides', N'10006732'),
(2534, N'Leaf Shine/Plant Cleaner', N'10005360'),
(2535, N'Plant Growth Regulators', N'10006733'),
(2536, N'Plant/Soil Fertilizer/Food', N'10003234'),
(2537, N'Pool/Water Feature Chemicals/Treatments', N'10003221'),
(2538, N'Seed Protection/ Mordants', N'10006734'),
(2539, N'Weed-Killer/ Herbicide', N'10003227'),
(2540, N'Barbecues (Non Powered)', N'10003328'),
(2541, N'Barbecues (Powered)', N'10003327'),
(2542, N'Greenhouse Heaters/Ventilators', N'10005369'),
(2543, N'Grill Islands (Lawn/Garden)', N'10003330'),
(2544, N'Lawn/Garden Cooking/Heating Appliances Other', N'10003335'),
(2545, N'Lawn/Garden Cooking/Heating Appliances Replacement Parts/Accessories', N'10003336'),
(2546, N'Lawn/Garden Cooking/Heating Appliances Variety Packs', N'10003334'),
(2547, N'Outdoor Heaters (Non Powered)', N'10003324'),
(2548, N'Outdoor Heaters (Powered)', N'10003323'),
(2549, N'Smokers – Cooking (Non Powered)', N'10006742'),
(2550, N'Smokers – Cooking (Powered)', N'10006741'),
(2551, N'Warmers/Drawers (Lawn/Garden)', N'10003332'),
(2552, N'Garden Carts (Powered)', N'10003376'),
(2553, N'Garden Tractors', N'10004102'),
(2554, N'Lawn Mowers/Rakers (Non Powered)', N'10003387'),
(2555, N'Lawn Mowers/Rakers (Powered)', N'10003353'),
(2557, N'Lawn Rollers (Powered)', N'10003841'),
(2478, N'Multifunction Kitchen Tools', N'10002176'),
(2477, N'Mincers/Choppers/Ricers/Pasta Makers (Non Powered)', N'10002148'),
(2476, N'Kitchen Slicers/Graters/Cutters', N'10002172'),
(2399, N'Household/Office Seating Variety Packs', N'10002200'),
(2400, N'Household/Office Sofa Beds', N'10002196'),
(2401, N'Household/Office Sofas (Non Powered)', N'10002195'),
(2402, N'Household/Office Sofas (Powered)', N'10002194'),
(2403, N'Inflatable Seating', N'10002198'),
(2404, N'Drawers', N'10002117'),
(2405, N'Filing Cabinets', N'10002185'),
(2406, N'Household Organisers/Tidies', N'10002189'),
(2407, N'Household/Office Bar Counters', N'10005810'),
(2408, N'Household/Office Boxes/Baskets', N'10002187'),
(2409, N'Household/Office Cupboards/Display Cabinets', N'10005199'),
(2410, N'Household/Office Partitions/Screens', N'10002190'),
(2411, N'Household/Office Shelving Units', N'10002184');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2412, N'Household/Office Storage/Display Furniture – Replacement Parts/Components', N'10005098'),
(2413, N'Household/Office Storage/Display Furniture Other', N'10003790'),
(2414, N'Household/Office Wardrobes/Lockers', N'10002118'),
(2415, N'Storage Rails/Holders', N'10002188'),
(2416, N'Universal Entertainment Units', N'10002186'),
(2417, N'Universal Turntables', N'10005743'),
(2418, N'Worktops/Countertops', N'10006731'),
(2419, N'Household/Office Desks/Workstations', N'10002203'),
(2420, N'Household/Office Tables', N'10002202'),
(2421, N'Household/Office Tables/Desks – Replacement Parts/Components', N'10005095'),
(2398, N'Household/Office Seating Other', N'10002201'),
(2422, N'Household/Office Tables/Desks Other', N'10002205'),
(2397, N'Household/Office Foot Rests', N'10002199'),
(2395, N'Household/Office Chairs/Stools (Non Powered)', N'10002193'),
(2372, N'Pillows', N'10002225'),
(2373, N'Fabric/Textile Furnishings Variety Packs', N'10003813'),
(2374, N'Curtains', N'10002214'),
(2375, N'Cushions', N'10002217'),
(2376, N'Fabric/Textile Towels', N'10002219'),
(2377, N'Furnishing Covers/Cloths – Detachable', N'10002216'),
(2378, N'Furnishing Floor Rugs/Mats – Detachable', N'10002218'),
(2379, N'Household/Office Fabric/Textile Furnishing Variety Packs', N'10002220'),
(2380, N'Household/Office Fabric/Textile Furnishings Other', N'10002221'),
(2381, N'Window Blinds', N'10002215'),
(2382, N'Display Stand', N'10006330'),
(2383, N'Household Adjustable Beds (Non Powered)', N'10002209'),
(2384, N'Household Adjustable Beds (Powered)', N'10002208'),
(2385, N'Household Bed Frames/Bedsteads', N'10002207'),
(2386, N'Household Beds – Replacement Parts/Components', N'10005096'),
(2387, N'Household Beds/Mattresses Other', N'10002212'),
(2388, N'Household Inflatable Beds/Water Beds', N'10002211'),
(2389, N'Household Mattresses', N'10002210'),
(2390, N'Furniture Castors/Pads/Slides', N'10005437'),
(2391, N'Shelf Grip Liner/Contact Paper', N'10005254'),
(2392, N'Household/Office Furniture Variety Packs', N'10003814'),
(2393, N'Bean Bags/Pouffes/Ottomans', N'10002197'),
(2394, N'Household/Office Chairs – Replacement Parts/Components', N'10005097'),
(2396, N'Household/Office Chairs/Stools (Powered)', N'10002192'),
(2370, N'Mattress/Pillow/Duvet Protectors', N'10002228'),
(2423, N'Clocks', N'10002252'),
(2425, N'Decorative Banners/Flags', N'10005816'),
(2453, N'Cookware/Bakeware Other', N'10002152');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2454, N'Hob Pots/Pans', N'10002144'),
(2455, N'Kitchen Cookware/Bakeware Variety Packs', N'10002151'),
(2456, N'Disposable Food Containers', N'10006331'),
(2457, N'Disposable Food Containers Other', N'10006333'),
(2458, N'Cooking Timers (Non Powered)', N'10002136'),
(2459, N'Food Measuring Equipment Other', N'10002142'),
(2460, N'Food Thermometers', N'10002140'),
(2461, N'Food Volume Measuring Equipment', N'10002139'),
(2462, N'Kitchen Scales (Non Powered)', N'10002143'),
(2463, N'Baby Cutlery (Non Disposable)', N'10006801'),
(2464, N'Baby Feeding Aids (Non Powered)', N'10000493'),
(2465, N'Cookie Guns/Food Decorating Syringes (Non Powered)', N'10005434'),
(2466, N'Corers/Peelers', N'10002169'),
(2467, N'Flour/Sugar Shakers', N'10005694'),
(2468, N'Food Funnels', N'10005429'),
(2469, N'Food Preparation Bowls', N'10005701'),
(2470, N'Food Preparation Brushes/Oil Pumps/Baster', N'10005426'),
(2471, N'Food Preparation Equipment Other', N'10002178'),
(2472, N'Gloves', N'10005894'),
(2473, N'Kitchen Knife Sharpeners (Non Powered)', N'10005201'),
(2474, N'Kitchen Knives/Cleavers', N'10002168'),
(2475, N'Kitchen Scissors', N'10000542'),
(2452, N'Cookware/Bakeware Accessories/Replacement Parts', N'10005675'),
(2424, N'Clocks – Replacement Parts', N'10004101'),
(2451, N'Cookware (Disposable)', N'10000554'),
(2449, N'Baby Feeding Other', N'10000825'),
(2426, N'Ornamental Furnishings Variety Packs', N'10003816'),
(2427, N'Artificial Flowers/Plants/Trees', N'10002232'),
(2428, N'Candle Holders/Accessories', N'10002249'),
(2429, N'Candles', N'10000555'),
(2430, N'Decorative Magnets/Stickers/Window Clings', N'10002234'),
(2431, N'Ornament Accessories', N'10005692'),
(2432, N'Ornaments', N'10002231'),
(2433, N'Ornaments Variety Packs', N'10002238'),
(2434, N'Seasonal Decorations (Non Powered)', N'10002236'),
(2435, N'Seasonal Decorations (Powered)', N'10002237'),
(2436, N'Sun/Dream Catchers/Windchimes', N'10002235'),
(2437, N'Vases', N'10002233'),
(2438, N'Mirrors', N'10002245'),
(2439, N'Paintings', N'10002240'),
(2440, N'Photographs', N'10002243'),
(2441, N'Picture Frames', N'10002246');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2442, N'Picture/Mirrors/Frames Other', N'10002248'),
(2443, N'Posters/Prints', N'10002241'),
(2444, N'Baby Feeding – Bottles', N'10000491'),
(2445, N'Baby Feeding – Replacement Parts', N'10000823'),
(2446, N'Baby Feeding – Tableware', N'10000490'),
(2447, N'Baby Feeding – Teats', N'10000724'),
(2448, N'Baby Feeding Accessories', N'10000492'),
(2450, N'Bakeware/Ovenware/Grillware (Non Disposable)', N'10002150'),
(2155, N'Dracaena Sanderiana – Cut Greens', N'10006536'),
(2154, N'Cut Green Variety Packs', N'10006535'),
(2153, N'Cut Greens Other', N'10006547'),
(1860, N'Drug Administration – Accessories', N'10000457'),
(1861, N'Drug Administration – Replacement Parts', N'10000912'),
(1862, N'Drug Administration Variety Packs', N'10000681'),
(1863, N'Enteral Feeding Equipment Variety Packs', N'10000921'),
(1864, N'Enteral Feeding Nutrition Bags/Containers', N'10000900'),
(1865, N'Enteral Feeding Tubes', N'10000901'),
(1866, N'First Aid – Accessories', N'10000449'),
(1867, N'First Aid – Dressings/Bandages/Plaster', N'10000448'),
(1868, N'First Aid – Sling/Support', N'10000450'),
(1869, N'First Aid Other', N'10000908'),
(1859, N'Drug Administration', N'10000456'),
(1870, N'Ice/Heated Pack', N'10000451'),
(1872, N'Flower Remedies', N'10000861'),
(1873, N'Flower/Homoeopathic/Homeopathic Remedies Variety Packs', N'10000862'),
(1874, N'Homoeopathic/Homeopathic Remedies – Individual Ingredients', N'10000859'),
(1875, N'Foot Care/Hygiene Aids', N'10000489'),
(1876, N'Foot/Leg Care/Treatments Other', N'10000907'),
(1877, N'Foot/Leg Care/Treatments Variety Packs', N'10000685'),
(1878, N'Medicated/Orthopaedic Footwear', N'10000488'),
(1879, N'Therapeutic Hosiery', N'10000474'),
(1880, N'Antacids/Indigestion/Flatulence Remedies', N'10000863'),
(1881, N'Diarrhoea Remedies', N'10000864'),
(1871, N'Poison Removal/Treatment Products', N'10000909'),
(1858, N'Rectal Medication', N'10000848'),
(1857, N'Intimate Lubrication', N'10000923'),
(1856, N'Enemas/Douches', N'10000851'),
(1833, N'Carbon Dioxide Gas', N'10006407'),
(1834, N'Nitrogen Gas', N'10006408'),
(1835, N'Technical Gases Other', N'10006410'),
(1836, N'Barrier Contraception Other', N'10000838'),
(1837, N'Condoms', N'10000460');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1838, N'Diaphragms/Cervical Caps', N'10000461'),
(1839, N'Spermicides', N'10000462'),
(1840, N'Family Planning Variety Packs', N'10000675'),
(1841, N'Hormonal Contraception', N'10000463'),
(1842, N'Intra-uterine Contraception', N'10000464'),
(1843, N'Dietary Aid – Appetite/Fat Control', N'10000465'),
(1844, N'Dietary Aid – Meal Replacement', N'10000466'),
(1845, N'Dietary Aids Other', N'10000841'),
(1846, N'Dietary Aids Variety Packs', N'10000650'),
(1847, N'Energy/Stimulant Products', N'10000917'),
(1848, N'Energy/Stimulant Products Other', N'10000918'),
(1849, N'Nutritional Supplements', N'10000468'),
(1850, N'Vitamins/Minerals', N'10000467'),
(1851, N'Vitamins/Minerals/Nutritional Supplements Variety Packs', N'10000651'),
(1852, N'Baby Treatments', N'10000500'),
(1853, N'Pacifiers/Teething Rings', N'10000504'),
(1854, N'Bladder/Genital/Rectal Products Other', N'10000849'),
(1855, N'Cystitis Products', N'10000847'),
(1882, N'Gastrointestinal Remedy Products Other', N'10000865'),
(1883, N'General/Multi-use Gastrointestinal Remedies', N'10000870'),
(1884, N'Laxatives', N'10000866'),
(1885, N'Nausea Remedies', N'10000868'),
(1913, N'Optic Appliances – Spectacle Frames', N'10000639'),
(1914, N'Optic Appliances – Spectacle Lenses', N'10000638'),
(1915, N'Optic Appliances – Spectacles – Ready To Wear', N'10000528'),
(1916, N'Optic Appliances – Sunglasses – Ready To Wear', N'10000637'),
(1917, N'Optic Appliances Care – Contact Lenses', N'10000527'),
(1918, N'Optic Appliances Care – Spectacles', N'10000688'),
(1919, N'Sensory Organs Care/Treatments Variety Packs', N'10000687'),
(1920, N'Acne/Rosacea Treatments', N'10000903'),
(1921, N'Anti-fungal Products', N'10000890'),
(1922, N'General/Multi Purpose Skin/Scalp Treatments', N'10000891'),
(1923, N'Hand Sanitizers / Antiseptics', N'10000885'),
(1924, N'Parasite Infestation Equipment (Non Powered)', N'10000892'),
(1925, N'Parasite Infestation Treatments', N'10000886'),
(1926, N'Psoriasis/Eczema/Dry Skin/Scalp Treatments', N'10000887'),
(1927, N'Skin/Scalp Treatment Products Variety Packs', N'10000905'),
(1928, N'Wart/Verruca/Corn/Callus Treatments', N'10000904'),
(1929, N'Sleeping Aids', N'10000872'),
(1930, N'Sleeping/Stress Relieving Products Variety Packs', N'10000874'),
(1931, N'Travel Sickness Preventatives – Medicinal', N'10000894'),
(1932, N'Travel Sickness Preventatives – Non Medicinal', N'10000895');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1933, N'Travel Sickness Products Variety Packs', N'10000896'),
(1934, N'Diagnostic Monitors Other', N'10000843'),
(1935, N'Home Diagnostic Monitors', N'10000455'),
(1912, N'Optic Appliances – Contact Lenses', N'10000529'),
(1832, N'Solid Fuels', N'10005266'),
(1911, N'Hearing Aids', N'10000487'),
(1909, N'Ear Preparations', N'10000525'),
(1886, N'Worming Preparations', N'10000867'),
(1887, N'Habit Treatment', N'10000459'),
(1888, N'Habit Treatment Variety Packs', N'10000690'),
(1889, N'Oral/Mouth Treatments', N'10002423'),
(1890, N'Arthritic/Rheumatic/Muscular Pain Relief', N'10000855'),
(1891, N'General/Multi-use Pain Relief', N'10000856'),
(1892, N'Headache/Migraine Pain Relief', N'10000857'),
(1893, N'Pain Relief (Powered)', N'10000853'),
(1894, N'Pain Relief Products Other', N'10000854'),
(1895, N'Disability Aids', N'10000458'),
(1896, N'Personal Aids Other', N'10000915'),
(1897, N'Personal Repellents', N'10000570'),
(1898, N'Allergy Prevention/Relief/Antihistamines', N'10000881'),
(1899, N'Chest Rubs', N'10000875'),
(1900, N'Cold/Cough Remedies', N'10000876'),
(1901, N'Decongestants Other', N'10000882'),
(1902, N'Humidifiers/Vaporisers (Non Powered)', N'10000883'),
(1903, N'Humidifiers/Vaporisers (Powered)', N'10000916'),
(1904, N'Inhalers/Nebulisers/Respirators (Non Powered)', N'10000877'),
(1905, N'Inhalers/Nebulisers/Respirators (Powered)', N'10000878'),
(1906, N'Nasal Strips/Sprays', N'10000879'),
(1907, N'Respiratory/Allergy Products Other', N'10000920'),
(1908, N'Throat Remedies', N'10000880'),
(1910, N'Eye Preparations', N'10000526'),
(1831, N'Liquid Fuels', N'10005263'),
(1830, N'Gel Fuels', N'10005265'),
(1829, N'Gas Fuels', N'10005264'),
(1752, N'Horseradish', N'10006124'),
(1753, N'Jerusalem Artichokes', N'10006125'),
(1754, N'Jicama Bean', N'10006344'),
(1755, N'Lilac Tannia', N'10006109'),
(1756, N'Lotus Root', N'10006364'),
(1757, N'Name Mapuey', N'10006351'),
(1758, N'Okra (Chinese)', N'10006366'),
(1759, N'Parsley Root (Hamburg)', N'10006127');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1760, N'Parsnips', N'10006126'),
(1761, N'Potatoes', N'10006104'),
(1762, N'Radishes', N'10006114'),
(1763, N'Salsify', N'10006367'),
(1764, N'Scorzonera', N'10006200'),
(1765, N'Sweet Potatoes', N'10006111'),
(1766, N'Taro', N'10006107'),
(1767, N'Turnip Rooted Chervil', N'10006418'),
(1768, N'White Radish (Daikon)', N'10006417'),
(1769, N'White Tannia', N'10006110'),
(1770, N'Yams', N'10006112'),
(1771, N'Mamey', N'10006365'),
(1772, N'Sapodillo', N'10006368'),
(1773, N'Sapote (Black)', N'10006369'),
(1774, N'Sapote (White)', N'10006370'),
(1751, N'Gobo Root/Burdock', N'10006363'),
(1775, N'Water Chestnuts', N'10006372'),
(1750, N'Ginseng', N'10006833'),
(1748, N'Celeriac', N'10006123'),
(1725, N'Sprouts', N'10006260'),
(1726, N'Carobs', N'10005986'),
(1727, N'Corn (Indian)', N'10006337'),
(1728, N'Okra', N'10006148'),
(1729, N'Sweetcorn', N'10006147'),
(1730, N'Black Eyed Peas', N'10006825'),
(1731, N'Lentils', N'10006454'),
(1732, N'Peas', N'10005984'),
(1733, N'Snow Peas', N'10006270'),
(1734, N'Sugar Snap Peas', N'10005985'),
(1735, N'Winged Pea', N'10006455'),
(1736, N'Chilli Peppers', N'10006102'),
(1737, N'Elongated Sweet Peppers (Pointed)', N'10006100'),
(1738, N'Flat Sweet Peppers (Tomato Peppers)', N'10006192'),
(1739, N'Pepper Variety Packs', N'10006195'),
(1740, N'Square Sweet Peppers (Blunt)', N'10006190'),
(1741, N'Square Tapering Sweet Peppers (Peg Top)', N'10006191'),
(1742, N'Arracacha', N'10006335'),
(1743, N'Arrowroot', N'10006416'),
(1744, N'Beetroot', N'10006121'),
(1745, N'Black Radishes', N'10006115'),
(1746, N'Carrots', N'10006122'),
(1747, N'Cassava', N'10006108');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1749, N'Ginger', N'10006113'),
(1936, N'Diagnostic Tests Other', N'10000844'),
(1776, N'Antroewa', N'10006452'),
(1778, N'Naranjilla/Lulo', N'10006760'),
(1806, N'Athletic Footwear – General Purpose', N'10001070'),
(1807, N'Athletic Footwear – Specialist', N'10001071'),
(1808, N'Footwear – Replacement Parts/Accessories', N'10000433'),
(1809, N'Footwear Accessories Variety Packs', N'10000700'),
(1810, N'Footwear Inserts', N'10001074'),
(1811, N'Shoe Cleaning/Care Preparations', N'10000400'),
(1812, N'Shoe Colour/Dyes', N'10000432'),
(1813, N'Boots – General Purpose', N'10001076'),
(1814, N'Shoes – General Purpose', N'10001077'),
(1815, N'Indoor Footwear – Fully Enclosed Uppers', N'10001078'),
(1816, N'Indoor Footwear – Partially Enclosed Uppers', N'10001079'),
(1817, N'Safety/Protective Occupational Overshoes', N'10001081'),
(1818, N'Safety/Protective Occupational Shoes', N'10001082'),
(1819, N'Safety/Protective/Occupational Boots', N'10001080'),
(1820, N'Fuel Pumps (Non Powered)', N'10005256'),
(1821, N'Fuel Pumps (Powered)', N'10005257'),
(1822, N'Gas Fuel Bottles/Canisters (Empty)', N'10005258'),
(1823, N'Liquid Fuel Bottles/Containers (Empty)', N'10005306'),
(1824, N'Fuel Additives', N'10005255'),
(1825, N'Fuels/Fuel Additives Variety Packs', N'10005262'),
(1826, N'Firelighting Tools/Matches', N'10000543'),
(1827, N'Firelighting Tools/Matches Accessories', N'10006842'),
(1828, N'Fuels/Ignition Aids Variety Packs', N'10000703'),
(1805, N'Vegetables – Unprepared/Unprocessed (Fresh) Variety Packs', N'10006171'),
(1777, N'Aubergines', N'10006128'),
(1804, N'Tomatoes Variety Packs', N'10006166'),
(1802, N'Tomatoes – Ribbed', N'10006164'),
(1779, N'Pepino', N'10006453'),
(1780, N'Tamarillo', N'10006358'),
(1781, N'Tomatillos', N'10006451'),
(1782, N'Asparagus', N'10006129'),
(1783, N'Bamboo Shoots', N'10006137'),
(1784, N'Cardoons', N'10006135'),
(1785, N'Celery', N'10006131'),
(1786, N'Fennel (subspecies azoricum)', N'10006272'),
(1787, N'Globe Artichokes', N'10006130'),
(1788, N'Leek', N'10006133'),
(1789, N'Palm Hearts', N'10006136');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1790, N'Rhubarb', N'10006134'),
(1791, N'Sweet Potato Stems', N'10006835'),
(1792, N'Aloe Vera', N'10006360'),
(1793, N'Sugar Cane', N'10006371'),
(1794, N'Agretti', N'10006461'),
(1795, N'Glasswort', N'10006460'),
(1796, N'Sea Kale', N'10006458'),
(1797, N'Sea Lavender', N'10006459'),
(1798, N'Tidal Sea Vegetables Other', N'10006262'),
(1799, N'Cherry Tomatoes – Oblong', N'10006161'),
(1800, N'Cherry Tomatoes – Round', N'10006162'),
(1801, N'Tomatoes – Oblong', N'10006163'),
(1803, N'Tomatoes – Round', N'10006165'),
(1937, N'Home Diagnostic Products – Accessories', N'10000454'),
(1938, N'Home Diagnostic Tests', N'10000453'),
(1939, N'Thermometers', N'10000452'),
(2076, N'Lilium', N'10006861'),
(2077, N'Muscari', N'10006855'),
(2078, N'Narcissus', N'10006862'),
(2079, N'Tulipa', N'10006863'),
(2080, N'Zantedeschia', N'10006865'),
(2081, N'Agapanthus – Cut Flowers', N'10006462'),
(2082, N'Alchemilla Mollis – Cut Flowers', N'10006463'),
(2083, N'Alstroemeria – Cut Flowers', N'10006464'),
(2084, N'Anemone Coronaria – Cut Flowers', N'10006465'),
(2085, N'Anthurium – Cut Flowers', N'10006466'),
(2086, N'Antirrhinum Majus – Cut Flowers', N'10006467'),
(2087, N'Aster – Cut Flowers', N'10006468'),
(2088, N'Bouvardia – Cut Flowers', N'10006469'),
(2089, N'Celosia Argentea – Cut Flowers', N'10006470'),
(2090, N'Chamelaucium Other – Cut Flowers', N'10006471'),
(2091, N'Chamelaucium Uncinatum – Cut Flowers', N'10006472'),
(2092, N'Chrysanthemum – Cut Flowers', N'10006473'),
(2093, N'Cut Flowers Other', N'10006502'),
(2094, N'Cymbidium – Cut Flowers', N'10006474'),
(2095, N'Dahlia – Cut Flowers', N'10006476'),
(2096, N'Delphinium – Cut Flowers', N'10006477'),
(2097, N'Dianthus Barbatus – Cut Flowers', N'10006478'),
(2098, N'Dianthus Other – Cut Flowers', N'10006479'),
(2075, N'Iris', N'10006859'),
(2099, N'Eryngium – Cut Flowers', N'10006480'),
(2074, N'Hyacinthus Orientalis', N'10006858');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2072, N'Gladiolus', N'10006857'),
(2049, N'Raclettes (Powered)', N'10001972'),
(2050, N'Rice Cookers/Steamers', N'10001977'),
(2051, N'Rotisseries/Roasters (Powered)', N'10001974'),
(2052, N'Sandwich/Waffle Makers', N'10001970'),
(2053, N'Slow Cookers/Hot Pots', N'10001975'),
(2054, N'Small Cooking Appliances Other', N'10002034'),
(2055, N'Small Cooking Appliances Replacement Parts/Accessories', N'10002035'),
(2056, N'Tajines (Powered)', N'10001987'),
(2057, N'Toaster Ovens', N'10001968'),
(2058, N'Toasters', N'10001967'),
(2059, N'Warming Trays (Powered)', N'10005359'),
(2060, N'Woks (Powered)', N'10001982'),
(2061, N'Small Domestic Appliances - Other', N'10006894'),
(2062, N'Water Dispensers – Tabletop', N'10003713'),
(2063, N'Alstroemeria Bouquets', N'10006768'),
(2064, N'Chrysanthemum Bouquets', N'10006767'),
(2065, N'Mini Carnation Bouquets', N'10006765'),
(2066, N'Other Bouquets', N'10006771'),
(2067, N'Tropical Flowers Bouquets', N'10006769'),
(2068, N'Allium', N'10006864'),
(2069, N'Bulbs/Corms/Rhizomes/Tubers - Other', N'10003290'),
(2070, N'Crocus', N'10006860'),
(2071, N'Dahlia', N'10006856'),
(2073, N'Hippeastrum', N'10006854'),
(2048, N'Pressure Cookers', N'10001976'),
(2100, N'Eustoma Russellianum – Cut Flowers', N'10006481'),
(2102, N'Gerbera – Cut Flowers', N'10006483'),
(2130, N'Syringa Vulgaris – Cut Flowers', N'10006512'),
(2131, N'Tanacetum Parthenium – Cut Flowers', N'10006513'),
(2132, N'Trachelium Caeruleum – Cut Flowers', N'10006514'),
(2133, N'Tulipa – Cut Flowers', N'10006515'),
(2134, N'Vanda – Cut Flowers', N'10006516'),
(2135, N'Veronica – Cut Flowers', N'10006517'),
(2136, N'Viburnum Opulus – Cut Flowers', N'10006518'),
(2137, N'Zantedeschia Aethiopica – Cut Flowers', N'10006519'),
(2138, N'Zantedeschia Other – Cut Flowers', N'10006520'),
(2139, N'Agapanthus – Cut Greens', N'10006521'),
(2140, N'Anthurium – Cut Greens', N'10006522'),
(2141, N'Asparagus Setaceus – Cut Greens', N'10006523'),
(2142, N'Asparagus Umbellatus – Cut Greens', N'10006524'),
(2143, N'Aspidistra Elatior – Cut Greens', N'10006525');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2144, N'Astilbe Other – Cut Greens', N'10006526'),
(2145, N'Brassica Oleracea – Cut Greens', N'10006527'),
(2146, N'Carthamus Tinctorius – Cut Greens', N'10006528'),
(2147, N'Corylus Avellana – Cut Greens', N'10006529'),
(2148, N'Crocosmia – Cut Greens', N'10006530'),
(2149, N'Cucumis – Cut Greens', N'10006531'),
(2150, N'Cucurbita Maxima – Cut Greens', N'10006532'),
(2151, N'Cucurbita Other – Cut Greens', N'10006533'),
(2152, N'Cucurbita Pepo – Cut Greens', N'10006534'),
(2129, N'Strelitzia Reginae – Cut Flowers', N'10006511'),
(2101, N'Freesia – Cut Flowers', N'10006482'),
(2128, N'Solidago – Cut Flowers', N'10006510'),
(2126, N'Ranunculus Other – Cut Flowers', N'10006508'),
(2103, N'Gladiolus – Cut Flowers', N'10006484'),
(2104, N'Gypsophila Paniculata – Cut Flowers', N'10006485'),
(2105, N'Helianthus Annuus – Cut Flowers', N'10006486'),
(2106, N'Hippeastrum – Cut Flowers', N'10006487'),
(2107, N'Hyacinthus Orientalis – Cut Flowers', N'10006488'),
(2108, N'Hydrangea Macrophylla – Cut Flowers', N'10006489'),
(2109, N'Hypericum Androsaemum – Cut Flowers', N'10006490'),
(2110, N'Hypericum Other – Cut Flowers', N'10006491'),
(2111, N'Hypericum X Inodorum – Cut Flowers', N'10006492'),
(2112, N'Ilex Verticillata – Cut Flowers', N'10006493'),
(2113, N'Iris – Cut Flowers', N'10006494'),
(2114, N'Lilium Longiflorum – Cut Flowers', N'10006495'),
(2115, N'Lilium Other – Cut Flowers', N'10006496'),
(2116, N'Limonium Other – Cut Flowers', N'10006497'),
(2117, N'Limonium Sinuatum – Cut Flowers', N'10006498'),
(2118, N'Matthiola Incana – Cut Flowers', N'10006499'),
(2119, N'Narcissus – Cut Flowers', N'10006500'),
(2120, N'Ornithogalum Saundersiae – Cut Flowers', N'10006501'),
(2121, N'Paeonia – Cut Flowers', N'10006503'),
(2122, N'Phalaenopsis – Cut Flowers', N'10006504'),
(2123, N'Phlox – Cut Flowers', N'10006505'),
(2124, N'Pittosporum – Cut Flowers', N'10006506'),
(2125, N'Ranunculus Asiaticus – Cut Flowers', N'10006507'),
(2127, N'Rosa – Cut Flowers', N'10006509'),
(2583, N'Garden Tables', N'10003245'),
(2047, N'Popcorn Makers', N'10001984'),
(2045, N'Pasta Cookers', N'10001979'),
(1967, N'Refrigerators', N'10003694'),
(1968, N'Wine Chillers', N'10001939');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1969, N'Hostess Trolleys (Powered)', N'10001956'),
(1970, N'Warming Appliances Other', N'10001957'),
(1971, N'Warming Drawers', N'10001955'),
(1972, N'Food Waste Disposers', N'10001929'),
(1973, N'Trash Compactors', N'10001928'),
(1974, N'Waste Disposing/Compacting Appliances Other', N'10001930'),
(1975, N'Cleaning Appliances Other', N'10002032'),
(1976, N'Cleaning Appliances Replacement Parts/Accessories', N'10002033'),
(1977, N'Disinfecting Cabinet', N'10006220'),
(1978, N'Floor Polishers/Shampoo Cleaner', N'10002030'),
(1979, N'Shoe Cleaners/Polishers', N'10003711'),
(1980, N'Steam Cleaners', N'10002031'),
(1981, N'Sweepers (Non Powered)', N'10005811'),
(1982, N'Vacuum Cleaner Bags', N'10005762'),
(1983, N'Vacuum Cleaners', N'10002028'),
(1984, N'Baby Feeding Aids (Powered)', N'10000820'),
(1985, N'Butter Makers (Powered)', N'10002015'),
(1986, N'Can Openers (Powered)', N'10002000'),
(1987, N'Candyfloss Machines', N'10002019'),
(1988, N'Carbonated Drinks Makers', N'10002016'),
(1989, N'Chocolate Fountains (Powered)', N'10005690'),
(1966, N'Refrigerator/Freezers', N'10003695'),
(1990, N'Coffee Bean Roasters', N'10006852'),
(1965, N'Refrigerating/Freezing Appliances Replacement Parts/Accessories', N'10001942'),
(1963, N'Ice Makers', N'10001938'),
(1940, N'Home Diagnostics Variety Packs', N'10000647'),
(1941, N'Pharmaceutical Drugs', N'10005845'),
(1942, N'Veterinary Pharmaceuticals', N'10000514'),
(1943, N'Dishwashers', N'10001964'),
(1944, N'Kitchen Washing Appliances Other', N'10001965'),
(1945, N'Kitchen Washing Appliances Replacement Parts/Accessories', N'10001966'),
(1946, N'Cooker Hoods', N'10005322'),
(1947, N'Hobs/Cooktops', N'10001951'),
(1948, N'Major Cooking Appliances Other', N'10001953'),
(1949, N'Major Cooking Appliances Replacement Parts/Accessories', N'10001954'),
(1950, N'Microwave Ovens', N'10001952'),
(1951, N'Ovens', N'10001950'),
(1952, N'Range Cookers/Stoves (Oven/Hob/Cook Top Combined)', N'10003690'),
(1953, N'Steam Ovens', N'10003691'),
(1954, N'Clothes Washers', N'10001959'),
(1955, N'Combination Clothes Washer/Dryers', N'10001961'),
(1956, N'Major Laundry Appliances Other', N'10001962');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1957, N'Major Laundry Appliances Replacement Parts/Accessories', N'10001963'),
(1958, N'Spin/Tumble Dryers', N'10003692'),
(1959, N'Water Dispensers – Freestanding', N'10003712'),
(1960, N'Beverage Chillers Other', N'10003710'),
(1961, N'Coolers/Heaters', N'10001940'),
(1962, N'Freezers', N'10003698'),
(1964, N'Refrigerating/Freezing Appliances Other', N'10001941'),
(2046, N'Pizza Makers', N'10001985'),
(1991, N'Coffee Grinders (Powered)', N'10002006'),
(1993, N'Dehydrators (Powered)', N'10002018'),
(2021, N'Air Conditioners – Portable', N'10005317'),
(2022, N'Air Controlling Appliances – Multifunction – Portable', N'10005335'),
(2023, N'Air Coolers – Portable', N'10005334'),
(2024, N'Air Dehumidifier - Portable (Non-Powered)', N'10006798'),
(2025, N'Air Dehumidifiers – Portable (Powered)', N'10005332'),
(2026, N'Air Heaters – Portable', N'10003992'),
(2027, N'Air Humidifiers – Portable', N'10005331'),
(2028, N'Air Ionisers – Portable', N'10005333'),
(2029, N'Air Purifiers – Portable', N'10005336'),
(2030, N'Fans – Portable', N'10005337'),
(2031, N'Portable Air Control Appliances Replacement Parts/Accessories', N'10005697'),
(2032, N'Breadmakers', N'10001983'),
(2033, N'Cake / Pie Maker', N'10006740'),
(2034, N'Cooking Appliances Variety Packs', N'10001991'),
(2035, N'Deep Fryers', N'10001981'),
(2036, N'Egg Cookers', N'10001980'),
(2037, N'Fondues (Powered)', N'10001986'),
(2038, N'Grills (Powered)', N'10001969'),
(2040, N'Hot Stones (Powered)', N'10001990'),
(2041, N'Mexican Diners (Powered)', N'10001988'),
(2042, N'Multi-cookers', N'10001978'),
(2043, N'Paella Makers', N'10001989'),
(2044, N'Pancake/Doughnut Makers', N'10001971'),
(2020, N'Laundry Care Appliances Replacement Parts/Accessories', N'10002027'),
(1992, N'Cookie Guns (Powered)', N'10005358'),
(2019, N'Ironing Steam Station', N'10005830'),
(2017, N'Clothes Presses', N'10002025'),
(1994, N'Food/Beverage Appliances Variety Packs', N'10002022'),
(1995, N'Food/Beverage Preparation Appliances Replacement Parts/Accessories', N'10002021'),
(1996, N'Frozen Drinks Makers/Ice Shavers (Powered)', N'10005689'),
(1997, N'Graters (Powered)', N'10002005'),
(1998, N'Hot Beverage Makers', N'10002011');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1999, N'Ice Cream Makers (Powered)', N'10002013'),
(2000, N'Ice Crushers/Ice Cube Makers (Powered)', N'10005357'),
(2001, N'Juicers (Powered)', N'10002007'),
(2002, N'Kettles (Powered)', N'10002012'),
(2003, N'Kitchen Blending Appliances', N'10006739'),
(2004, N'Kitchen Chopping Appliances', N'10006737'),
(2005, N'Kitchen Combination Mixing/Blending/Chopping Appliances', N'10006735'),
(2006, N'Kitchen Mixing Appliances', N'10006738'),
(2007, N'Kitchen Scales (Powered)', N'10005695'),
(2008, N'Kitchen Slicing Appliances', N'10006736'),
(2009, N'Knife Sharpeners (Powered)', N'10002002'),
(2010, N'Knives (Powered)', N'10001998'),
(2011, N'Meat Grinders/Mincers (Powered)', N'10002004'),
(2012, N'Party Drink Fountains (Powered)', N'10005868'),
(2013, N'Vacuum Sealers (Powered)', N'10002003'),
(2014, N'Wine/Bottle Openers (Powered)', N'10005691'),
(2015, N'Yogurt Makers', N'10002014'),
(2016, N'Clothes Irons (Powered)', N'10002023'),
(2018, N'Ironing Boards (Powered)', N'10002024'),
(2584, N'Hammocks', N'10003250'),
(2585, N'Lawn/Garden Furnishings Other', N'10003253'),
(2586, N'Lawn/Garden Furnishings Replacement Parts/Accessories', N'10003251'),
(3153, N'Paper Shredders (Powered)', N'10005119'),
(3154, N'Stationery Cutters/Trimmers Other', N'10001306'),
(3155, N'Stationery Scissors', N'10005371'),
(3156, N'Business Forms/Paper – Pre-printed', N'10001305'),
(3157, N'Exercise Books', N'10005893'),
(3158, N'Labels/Coupons/Tickets', N'10001313'),
(3159, N'Paper/Card – Unprinted', N'10001304'),
(3160, N'Stationery Paper/Card/Film Other', N'10005120'),
(3161, N'Transparencies/Acetates', N'10001314'),
(3162, N'Book Covers', N'10005125'),
(3152, N'Paper Shredders (Non Powered)', N'10001309'),
(3163, N'Cash/Money Boxes', N'10001316'),
(3165, N'Stationery Files/Folders/Wallets', N'10001318'),
(3166, N'Stationery Item Storage/Desk Accessories', N'10001320'),
(3167, N'Stationery Storage/Filing – Replacement Parts/Accessories', N'10001322'),
(3168, N'Stationery Storage/Filing Other', N'10001321'),
(3169, N'Stationery Storage/Filing Variety Packs', N'10001323'),
(3170, N'Stationery/Office Machinery Variety Packs', N'10001325'),
(3171, N'Correction Aids', N'10001226'),
(3172, N'Desktop Mats', N'10005206');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3173, N'Ink', N'10001225'),
(3174, N'Measuring/Geometrical Equipment (Stationery)', N'10001231'),
(3164, N'Pencil/Pen Cases', N'10006897'),
(3151, N'Paper Guillotines/Trimmers', N'10001302'),
(3150, N'Hole Paper Punches (Powered)', N'10001312'),
(3149, N'Hole Paper Punches (Non Powered)', N'10001311'),
(3126, N'Postal Weighing Scales (Non Powered)', N'10001267'),
(3127, N'Postal/Packaging Accessories', N'10001269'),
(3128, N'Postal/Packaging Equipment/Aids/Accessories Other', N'10001270'),
(3129, N'Stamping Equipment (Non Powered)', N'10001241'),
(3130, N'Flip-chart Stands', N'10001275'),
(3131, N'Overhead Projectors', N'10005445'),
(3132, N'Pointers (Non Powered)', N'10001276'),
(3133, N'Pointers (Powered)', N'10001277'),
(3134, N'Presentation Boards (Non Powered)', N'10001278'),
(3135, N'Presentation Boards (Powered)', N'10006406'),
(3136, N'Presentation Equipment Accessories', N'10001281'),
(3137, N'Presentation Equipment Other', N'10001280'),
(3138, N'Projection Tables', N'10005766'),
(3139, N'Adhesive Paste/Glue Removers', N'10005444'),
(3140, N'Binding Accessories', N'10001286'),
(3141, N'Binding Machines (Non Powered)', N'10001287'),
(3142, N'Binding Machines (Powered)', N'10001288'),
(3143, N'Stationery Adhesive Tapes', N'10005126'),
(3144, N'Stationery Adhesives/Binders/Fasteners Other', N'10001295'),
(3145, N'Stationery Fasteners', N'10001289'),
(3146, N'Stationery Glues', N'10001292'),
(3147, N'Stationery Staple Removers', N'10001298'),
(3148, N'Stationery Staplers (Powered)', N'10001300'),
(3175, N'Pencil Sharpeners (Non Powered)', N'10001232'),
(3176, N'Pencil Sharpeners (Powered)', N'10001233'),
(3177, N'Pencils (Stationery)', N'10001234'),
(3178, N'Pens (Stationery)', N'10001235'),
(3206, N'Audio Periodicals', N'10004104'),
(3207, N'Digital Periodical Content', N'10000927'),
(3208, N'Periodicals Variety Packs', N'10004108'),
(3209, N'Printed Periodicals', N'10000928'),
(3210, N'Textual/Printed/Reference Materials Variety Packs', N'10002103'),
(3211, N'Tool Belts/Holsters/Pouches', N'10003678'),
(3212, N'Tool Boxes/Cases', N'10003676'),
(3213, N'Tool Cabinets', N'10003674'),
(3214, N'Tool Carrybags/Wallets', N'10003677');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3215, N'Tool Carts', N'10003578'),
(3216, N'Tool Storage Other', N'10005102'),
(3217, N'Roller Stands', N'10003572'),
(3218, N'Router Tables', N'10005806'),
(3219, N'Saw Horses/Trestles', N'10003470'),
(3220, N'Work Benches', N'10003468'),
(3221, N'Workshop Aids Other', N'10005101'),
(3222, N'Workshop Cloths/Rags', N'10005723'),
(3223, N'Awls', N'10003490'),
(3224, N'Awls/Punches/Nailsets Variety Packs', N'10003778'),
(3225, N'Punches', N'10003487'),
(3226, N'Hand Trucks/Dollies', N'10003497'),
(3227, N'Ladders', N'10003821'),
(3228, N'Platforms/Scaffolding', N'10003473'),
(3205, N'Printed Maps', N'10004105'),
(3125, N'Postal Tubes/Boxes', N'10001266'),
(3204, N'Electronic Maps', N'10004106'),
(3202, N'Digital eBook Content', N'10000925'),
(3179, N'Stencils (Stationery)', N'10001236'),
(3180, N'Writing Implements – Replacement Parts', N'10001229'),
(3181, N'Writing/Design Implements/Aids Other', N'10001228'),
(3182, N'Stationery/Office Machinery/Occasion Supplies Variety Packs', N'10003771'),
(3183, N'Storage Barrels/Kegs (Empty)', N'10005846'),
(3184, N'Storage Drums (Empty)', N'10005847'),
(3185, N'Portable Storage Cylinders (Empty)', N'10005852'),
(3186, N'Storage Bottles (Empty)', N'10005851'),
(3187, N'Pallet Converters/Frames', N'10005857'),
(3188, N'Pallets', N'10005854'),
(3189, N'Racks', N'10005858'),
(3190, N'Slip Sheets', N'10005856'),
(3191, N'Transport Dollies', N'10005855'),
(3192, N'Storage/Haulage Boxes (Empty)', N'10005848'),
(3193, N'Storage/Haulage Crates (Empty)', N'10005849'),
(3194, N'Storage/Haulage Trays (Empty)', N'10005850'),
(3195, N'Air Freight Containers (Empty)', N'10005860'),
(3196, N'Flexible Bulk Containers (Empty)', N'10005861'),
(3197, N'Ocean Intermodal Freight Containers (Empty)', N'10005859'),
(3198, N'Rigid Intermediate Bulk Containers (Empty)', N'10005862'),
(3199, N'Storage/Haulage Tanks (Empty)', N'10005853'),
(3200, N'Audio Books', N'10004103'),
(3201, N'Books Variety Packs', N'10004107'),
(3203, N'Printed Books/Compositions', N'10000926');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3124, N'Postal Packaging/Wrap', N'10001273'),
(3123, N'Postal Labelling Machines', N'10001245'),
(3122, N'Postage Stamps', N'10006849'),
(3045, N'Sports Bats/Sticks/Clubs', N'10001780'),
(3046, N'Sports Bats/Sticks/Clubs Other', N'10001787'),
(3047, N'Pumps (Non Powered)', N'10005702'),
(3048, N'Sports Equipment Accessories Other', N'10001903'),
(3049, N'Sports Equipment Bags/Cases/Covers', N'10001892'),
(3050, N'Sports Equipment Storage Racks/Holders', N'10001898'),
(3051, N'Sports Goals/Nets Accessories', N'10001894'),
(3052, N'Sports Goals/Nets/Enclosures', N'10001893'),
(3053, N'Sports Marking Equipment', N'10001896'),
(3054, N'Sports Mats/Carpets', N'10001900'),
(3055, N'Sports Scoring Equipment (Non Powered)', N'10001899'),
(3056, N'Sports Scoring Equipment (Powered)', N'10004111'),
(3057, N'Sports Target Pins/Skittles/Stumps', N'10001897'),
(3058, N'Sports Equipment Variety Packs', N'10003688'),
(3059, N'Sports Personal Protective Equipment Variety Packs', N'10001911'),
(3060, N'Sports Protective Body Padding/Guards', N'10001907'),
(3061, N'Sports Protective Goggles/Eye Masks', N'10001905'),
(3062, N'Sports Protective Mouth Guards', N'10001904'),
(3063, N'Sports Protective Support Belts', N'10001909'),
(3064, N'Sports Tables', N'10001855'),
(3065, N'Sports Tables Other', N'10001859'),
(3066, N'Boards/Skis (Water Sports)', N'10001844'),
(3067, N'Boards/Skis (Water Sports) – Replacement Parts/Accessories', N'10001845'),
(3044, N'Sports Balls/Pucks/Shuttlecocks/Frisbees/Boomerangs Other', N'10001775'),
(3068, N'Diving Equipment', N'10001848'),
(3043, N'Sports Balls', N'10001768'),
(3041, N'Pucks', N'10001769'),
(3018, N'Personal Fitness Sports Equipment Other', N'10001825'),
(3019, N'Sports Exercise Monitors', N'10001822'),
(3020, N'Racquet Sports – Replacement Parts/Accessories', N'10001778'),
(3021, N'Racquet Sports Equipment Other', N'10004097'),
(3022, N'Racquets', N'10001776'),
(3023, N'Scooter/Skateboard Sports Equipment Other', N'10001843'),
(3024, N'Scooters/Skateboards/Hoverboards (Powered)', N'10005814'),
(3025, N'Skateboarding Sports Equipment – Replacement Parts/Accessories', N'10001841'),
(3026, N'Skateboards (Non Powered)', N'10001840'),
(3027, N'Curling Stones', N'10001794'),
(3028, N'Skis/Ski Boards/Snow Boards', N'10001792'),
(3029, N'Sleds', N'10001790');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3030, N'Snow/Ice Sports Equipment – Replacement Parts/Accessories', N'10001795'),
(3031, N'Snow/Ice Sports Equipment Other', N'10001797'),
(3032, N'Airguns', N'10001873'),
(3033, N'Firearms Ammunition', N'10001874'),
(3034, N'Handguns/Pistols', N'10001870'),
(3035, N'Rifles', N'10001871'),
(3036, N'Shotguns', N'10001872'),
(3037, N'Sporting Firearms – Replacement Parts/Accessories', N'10001877'),
(3038, N'Sporting Firearms Equipment Other', N'10001879'),
(3039, N'Boomerangs', N'10001772'),
(3040, N'Frisbees', N'10001771'),
(3042, N'Shuttlecocks', N'10001770'),
(3229, N'Pulley Puller (Hand)', N'10006778'),
(3069, N'Swimming Training Aids', N'10001847'),
(3071, N'Swimming/Surfing/Diving Sports Equipment Other', N'10001854'),
(3099, N'Party Crackers', N'10001220'),
(3100, N'Party Horns/Blowers', N'10005436'),
(3101, N'Pinatas', N'10001223'),
(3102, N'Calculators/Currency Converters (Powered)', N'10001242'),
(3103, N'Cash/Money Registers (Powered)', N'10001243'),
(3104, N'Laminating Machine Consumables', N'10001246'),
(3105, N'Laminating Machines (Powered)', N'10001247'),
(3106, N'Multifunctional Devices', N'10005229'),
(3107, N'Office Machinery Other', N'10001248'),
(3108, N'Photocopier Consumables', N'10001251'),
(3109, N'Photocopiers', N'10001252'),
(3110, N'Typewriter Consumables', N'10005676'),
(3111, N'Typewriters (Non Powered)', N'10001253'),
(3112, N'Typewriters (Powered)', N'10001254'),
(3113, N'Calendars/Planners', N'10001255'),
(3114, N'Contact Information Books/Pads', N'10001256'),
(3115, N'Organizational Planning Stationery – Replacement Parts/Accessories', N'10001258'),
(3116, N'Organizational Planning Stationery Other', N'10001257'),
(3117, N'Personal Organizers/Diaries (Non Powered)', N'10001260'),
(3118, N'Sticky Notes/Paper Cubes', N'10005118'),
(3119, N'Envelopes/Mailers', N'10001261'),
(3120, N'Franking Machines', N'10001262'),
(3121, N'Letter Openers (Non Powered)', N'10001264'),
(3098, N'Occasion Supplies Other', N'10001217'),
(3070, N'Swimming/Surfing/Diving Sports Equipment – Replacement Parts/Accessories', N'10001852'),
(3097, N'Confetti', N'10001215'),
(3095, N'Invitation Pads/Notelets', N'10001212');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3072, N'Arrows', N'10001863'),
(3073, N'Bows', N'10001862'),
(3074, N'Darts', N'10001860'),
(3075, N'Target Sports Equipment – Replacement Parts/Accessories', N'10001867'),
(3076, N'Target Sports Equipment Other', N'10001869'),
(3077, N'Targets (Non Powered)', N'10001866'),
(3078, N'Targets (Powered)', N'10001865'),
(3079, N'Jumping Sports Equipment', N'10001764'),
(3080, N'Running Sports Equipment', N'10001763'),
(3081, N'Throwing Sports Equipment', N'10001762'),
(3082, N'Track/Field Sports Equipment Other', N'10001767'),
(3083, N'Trekking/Mountaineering Sports Equipment', N'10001798'),
(3084, N'Trekking/Mountaineering Sports Equipment Other', N'10001805'),
(3085, N'Watercraft', N'10001887'),
(3086, N'Watercraft – Replacement Parts/Accessories', N'10001889'),
(3087, N'Watercraft Sports Equipment Other (Non Powered)', N'10001891'),
(3088, N'Gift Wrap', N'10001201'),
(3089, N'Gift Wrap Accessories', N'10001203'),
(3090, N'Gift Wrap/Accessories Other', N'10001202'),
(3091, N'Greeting Cards/Gift Wrap/Occasion Supplies Variety Packs', N'10001205'),
(3092, N'Greeting Card Display Holders', N'10001206'),
(3093, N'Greeting Cards/Invitations', N'10001209'),
(3094, N'Greeting Cards/Invitations Other', N'10001207'),
(3096, N'Postcards', N'10001213'),
(3230, N'Suction Lifters', N'10003498'),
(3231, N'Wheelbarrows – Non Powered', N'10003496'),
(3232, N'Chisels', N'10003488'),
(3368, N'Shapers – Stationary', N'10003746'),
(3369, N'Spindle Sanders', N'10003610'),
(3370, N'Surface Planers – Stationary', N'10003729'),
(3371, N'Table Saws – Stationary', N'10003601'),
(3372, N'Wet Saws/Tile/Glass Cutters', N'10003596'),
(3373, N'Lottery and Scratch Cards', N'10006755'),
(3374, N'Board Games (Non Powered)', N'10005133'),
(3375, N'Board Games (Powered)', N'10005134'),
(3376, N'Board Games/Cards/Puzzles – Accessories/Replacement Parts', N'10005135'),
(3377, N'Board Games/Cards/Puzzles Other', N'10005136'),
(3378, N'Card Games (Non Powered)', N'10005138'),
(3379, N'Card Games (Powered)', N'10005139'),
(3380, N'Puzzles (Non Powered)', N'10005140'),
(3381, N'Puzzles (Powered)', N'10005141'),
(3382, N'Baby/Infant Stimulation Toys (Non Powered)', N'10005153');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3383, N'Baby/Infant Stimulation Toys (Powered)', N'10005154'),
(3384, N'Bath/Pool Water Toys', N'10005155'),
(3385, N'Communication Toys (Non Powered)', N'10005156'),
(3386, N'Communication Toys (Powered)', N'10005157'),
(3387, N'Developmental/Educational Toys Other', N'10005159'),
(3388, N'Push/Pull-along Toys (Non Powered)', N'10005161'),
(3389, N'Push/Pull-along Toys (Powered)', N'10005162'),
(3390, N'Scientific Toys (Non Powered)', N'10005163'),
(3367, N'Scroll Saws – Stationary', N'10003602'),
(3391, N'Scientific Toys (Powered)', N'10005164'),
(3366, N'Radial Arm Saws', N'10003603'),
(3364, N'Lathes – Stationary (Powered)', N'10003605'),
(3341, N'Screw Guns', N'10003657'),
(3342, N'Screwdrivers/Rotary Tools', N'10003654'),
(3343, N'Soldering/Brazing Irons', N'10003649'),
(3344, N'Staplers (Powered)', N'10003665'),
(3345, N'Straight/Die Grinders', N'10003647'),
(3346, N'Stud Finders/Detectors/Sensors', N'10005869'),
(3347, N'Surface Grinders', N'10003648'),
(3348, N'Surface/Thickness Planers – Portable', N'10003615'),
(3349, N'Table Saws – Portable', N'10003627'),
(3350, N'Tappers', N'10003639'),
(3351, N'Wall/Ceiling Covering Tools – Powered', N'10003884'),
(3352, N'Welding/Blow Torches', N'10003744'),
(3353, N'Hoists/Winches', N'10003679'),
(3354, N'Power Tools – Lifting/Handling Equipment Other', N'10003749'),
(3355, N'Pulley Puller (Powered)', N'10006779'),
(3356, N'Air Compressors – Stationary', N'10005230'),
(3357, N'Band Saws – Stationary', N'10003597'),
(3358, N'Belt Sanders – Stationary', N'10003668'),
(3359, N'Bench Grinders', N'10003598'),
(3360, N'Bench Jointers', N'10003604'),
(3361, N'Disc Sanders', N'10003609'),
(3362, N'Drill Presses/Mortisers', N'10003613'),
(3363, N'Jointer Planers – Stationary', N'10003730'),
(3365, N'Power Tools – Stationary – Replacement Parts/Accessories', N'10003608'),
(3340, N'Routers', N'10003737'),
(3392, N'Spinning Tops/Yo-Yos', N'10005165'),
(3394, N'Toy Building Blocks (Powered)', N'10005167'),
(3422, N'Outdoor Play Structures', N'10005182'),
(3423, N'Musical Toys (Non Powered)', N'10005177'),
(3424, N'Musical Toys (Powered)', N'10005178');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3425, N'Musical Toys Other', N'10005179'),
(3426, N'Role Play – Housekeeping/Gardening/DIY Toys', N'10005684'),
(3427, N'Role Play – Kitchen Toys', N'10005250'),
(3428, N'Role Play – Shopping/Office/Business Toys', N'10005685'),
(3429, N'Table Games (Non Powered)', N'10005183'),
(3430, N'Table Games (Powered)', N'10005184'),
(3431, N'Table Games Other', N'10005185'),
(3432, N'Car/Train Set – Replacement Parts/Accessories', N'10005192'),
(3433, N'Car/Train Sets (Non Powered)', N'10005190'),
(3434, N'Car/Train Sets (Powered)', N'10005191'),
(3435, N'Toy Vehicles – Non-ride (Non Powered)', N'10005193'),
(3436, N'Toy Vehicles – Non-ride (Powered)', N'10005194'),
(3437, N'Toy Vehicles – Non-ride Other', N'10005195'),
(3438, N'Toys – Ride-on (Non Powered)', N'10005187'),
(3439, N'Toys – Ride-on (Powered)', N'10005188'),
(3440, N'Toys – Ride-on Accessories', N'10005441'),
(3441, N'Practical Jokes', N'10005443'),
(3442, N'Toys/Games Variety Packs', N'10005186'),
(3443, N'General', NULL),
(3444, N'Medical Devices', N'10005844'),
(3421, N'Outdoor Games/Play Structures Other', N'10005180'),
(3393, N'Toy Building Blocks (Non Powered)', N'10005166'),
(3420, N'Indoor/Outdoor Games', N'10005181'),
(3418, N'Fancy Dress Costumes', N'10005172'),
(3395, N'Toy Computer Accessories', N'10005712'),
(3396, N'Toy Computers', N'10005158'),
(3397, N'Toy Drawing Boards/Accessories', N'10005442'),
(3398, N'Toy Model Construction (Non Powered)', N'10005168'),
(3399, N'Toy Model Construction (Powered)', N'10005169'),
(3400, N'Viewing Toys (Non Powered)', N'10005170'),
(3401, N'Viewing Toys (Powered)', N'10005171'),
(3402, N'Action Figures (Non Powered)', N'10006395'),
(3403, N'Action Figures (Powered)', N'10006396'),
(3404, N'Dolls/Puppets/Soft Toys Other', N'10005144'),
(3405, N'Dolls/Soft Toys (Non Powered)', N'10005142'),
(3406, N'Dolls/Soft Toys (Powered)', N'10005143'),
(3407, N'Puppets', N'10005145'),
(3408, N'Action Figure Accessories', N'10006397'),
(3409, N'Dolls Beauty/Cosmetic Accessories', N'10005146'),
(3410, N'Dolls Buildings/Settings', N'10005147'),
(3411, N'Dolls Clothing', N'10005148'),
(3412, N'Dolls Furniture', N'10005149');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3413, N'Dolls/Puppets/Soft Toys Accessories Other', N'10005150'),
(3414, N'Puppet Theatres', N'10005152'),
(3415, N'Styling Dolls Heads (Non Powered)', N'10005439'),
(3416, N'Fancy Dress Accessories (Non Powered)', N'10005175'),
(3417, N'Fancy Dress Accessories (Powered)', N'10005176'),
(3419, N'Fancy Dress Costumes/Accessories Other', N'10005173'),
(3017, N'Personal Fitness Sports Equipment – Replacement Parts/Accessories', N'10001823'),
(3339, N'Rotary Saws', N'10003641'),
(3337, N'Reciprocating Saws', N'10003629'),
(3260, N'Measuring Wheels', N'10003461'),
(3261, N'Micrometers', N'10003459'),
(3262, N'Moisture Meter (Soil)', N'10006776'),
(3263, N'Plumb Bobs', N'10003466'),
(3264, N'Rulers (DIY)', N'10003455'),
(3265, N'Squares (DIY)', N'10003464'),
(3266, N'Tape Measures (DIY)', N'10003458'),
(3267, N'Thermal Leak Detector', N'10006777'),
(3268, N'Hammer Tacker – Non Powered', N'10003504'),
(3269, N'Nailing/Stapling/Fixing Tool Replacement Pars/Accessories', N'10003507'),
(3270, N'Staple/Nail Gun – Non Powered', N'10003502'),
(3271, N'Flaring Tools', N'10003549'),
(3272, N'Pipe Threaders – Non Powered', N'10003642'),
(3273, N'Tubing Benders', N'10003548'),
(3274, N'Files', N'10003533'),
(3275, N'Planes', N'10003544'),
(3276, N'Planes/Shapers/Files/Rasps Variety Packs', N'10003807'),
(3277, N'Surface Forming Tool Consumables', N'10003546'),
(3278, N'Bolt/Chain Cutters', N'10003481'),
(3279, N'Forceps (DIY)', N'10006781'),
(3280, N'Pliers/Pincers/Grabbers', N'10003532'),
(3281, N'Snips/Shears/Nibblers – Sheet Metal (Non Powered)', N'10003486'),
(3282, N'Fluid Guns', N'10006782'),
(3259, N'Marking Chalks/String Lines', N'10005707'),
(3283, N'Blades – Saw – Non Powered', N'10003800'),
(3258, N'Dividers/Compass (DIY)', N'10003454'),
(3256, N'Masonry Trowels', N'10003594'),
(3233, N'Chisels/Gouges Variety Packs', N'10003787'),
(3234, N'Crowbars/Pry Bars', N'10003499'),
(3235, N'Nut Splitters', N'10003563'),
(3236, N'Drilling Replacement Parts/Accessories', N'10003542'),
(3237, N'Drills – Non Powered', N'10003541'),
(3238, N'Paint Application Accessories', N'10005656');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3239, N'Paint Applicators – Non Powered', N'10005654'),
(3240, N'Painting Replacement Parts', N'10002481'),
(3241, N'Plaster Hawks', N'10003573'),
(3242, N'Wall/Ceiling Covering Tools – Non Powered', N'10005672'),
(3243, N'Funnels (DIY)', N'10005714'),
(3244, N'Gas Torches', N'10006783'),
(3245, N'Grinders (Non Powered)', N'10003538'),
(3246, N'Scrapers', N'10003543'),
(3247, N'Anvils (DIY)', N'10003552'),
(3248, N'Hammers (DIY)', N'10003500'),
(3249, N'Hammers/Mallets/Hatches Replacement Parts/Accessories', N'10003501'),
(3250, N'Hatchets (DIY)', N'10003789'),
(3251, N'Mallets (DIY)', N'10003788'),
(3252, N'Knife Blades – Non Powered (Hobby/Utility)', N'10003824'),
(3253, N'Knives – Non Powered (Hobby/Utility)', N'10003492'),
(3254, N'Knives – Non Powered Replacement Parts/Accessories', N'10003823'),
(3255, N'Cutters – Glass (Non Powered)', N'10003485'),
(3257, N'Bevel Gauges', N'10005716'),
(3338, N'Rotary Hammers', N'10003660'),
(3284, N'Saws – Hand – Replacement Parts/Accessories', N'10003801'),
(3286, N'Screwdriver Sets', N'10003530'),
(3314, N'Drain Augers (Powered)', N'10003741'),
(3315, N'Drill/Drivers (Powered)', N'10003653'),
(3316, N'Drills – Combination (Powered)', N'10003658'),
(3317, N'Finishing Sanders', N'10003669'),
(3318, N'Foam Cutters – Powered', N'10003638'),
(3319, N'Generators', N'10005211'),
(3320, N'Glue Guns – Powered', N'10005213'),
(3321, N'Grease Guns (Powered)', N'10003663'),
(3322, N'Hammer Drills', N'10003659'),
(3323, N'Heat Guns', N'10003662'),
(3324, N'Impact Drivers', N'10003655'),
(3325, N'Impact Wrenches', N'10003656'),
(3326, N'Jigsaws – Powered', N'10003631'),
(3327, N'Jointer Planers – Portable', N'10003616'),
(3328, N'Laminate Trimmers', N'10003626'),
(3329, N'Laser Levels', N'10003620'),
(3330, N'Metal Detectors', N'10006277'),
(3331, N'Mitre Saws – Portable', N'10003738'),
(3332, N'Nail Guns (Powered)', N'10003666'),
(3333, N'Nibblers/Shears – Metal (Powered)', N'10003632'),
(3334, N'Paint Applicators – Powered', N'10005653');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (3335, N'Pipe Cutters (Powered)', N'10003640'),
(3336, N'Power Tools – Hand-held Portable Other', N'10003750'),
(3313, N'Distance/Linear Measurers (Powered)', N'10003618'),
(3285, N'Saws – Non Powered', N'10003799'),
(3312, N'Disc Sanders – Portable', N'10005248'),
(3310, N'Cut-off Tools', N'10003645'),
(3287, N'Screwdrivers – Non Powered', N'10003528'),
(3288, N'Screwdrivers Other', N'10003825'),
(3289, N'Dies (Non Powered)', N'10003550'),
(3290, N'Taps (Non Powered)', N'10003808'),
(3291, N'Tools/Equipment – Hand Variety Packs', N'10005645'),
(3292, N'Clamps', N'10003535'),
(3293, N'Vises', N'10003536'),
(3294, N'Vises/Clamps Replacement Parts/Accessories', N'10003537'),
(3295, N'Socket Sets', N'10005252'),
(3296, N'Wrenches/Spanners', N'10003508'),
(3297, N'Wrenches/Spanners Sets', N'10003796'),
(3298, N'Wrenches/Spanners/Keys Variety Packs', N'10003795'),
(3299, N'Air Compressors – Portable', N'10003555'),
(3300, N'Angle Grinders', N'10003644'),
(3301, N'Angle Measures (Powered)', N'10003619'),
(3302, N'Arc Welders', N'10003651'),
(3303, N'Band Saws – Portable', N'10005231'),
(3304, N'Belt Sanders – Portable', N'10003742'),
(3305, N'Biscuit Joiners', N'10005718'),
(3306, N'Caulking Guns (Powered)', N'10003664'),
(3307, N'Cement/Mortar Mixing Machines', N'10005214'),
(3308, N'Chisels (Powered)', N'10003643'),
(3309, N'Circular Saws', N'10005223'),
(3311, N'Detail Sanders', N'10003672'),
(1724, N'Seedlings - Ready to Eat', N'10006259'),
(3016, N'Gym Accessories', N'10001819'),
(3014, N'Exercise Machines (Powered)', N'10001814'),
(2722, N'Vertebrates Other', N'10005476'),
(2723, N'Lubricants Variety Packs', N'10005356'),
(2724, N'Lubricating Greases', N'10005268'),
(2725, N'Lubricating Oils/Fluids', N'10005267'),
(2726, N'Lubricating Products Variety Packs', N'10005270'),
(2727, N'Anti-corrosives', N'10005273'),
(2728, N'Antifreeze/Coolants', N'10005272'),
(2729, N'Anti-spatter Products', N'10005321'),
(2730, N'Protective Compounds Variety Packs', N'10005275');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2731, N'Drain Pans', N'10005277'),
(2721, N'Swine (Pigs)', N'10005464'),
(2732, N'Lubricant Containers/Dispensers (Empty)', N'10005276'),
(2734, N'Lubricating Oil/Fluid Pumps (Non Powered)', N'10005281'),
(2735, N'Lubricating Oil/Fluid Pumps (Powered)', N'10005282'),
(2736, N'Brasswind Musical Instrument Accessories (Non Powered)', N'10004116'),
(2737, N'Keyboard/Piano Accessories (Powered)', N'10004117'),
(2738, N'Metronomes/Tuners (Non Powered)', N'10004125'),
(2739, N'Metronomes/Tuners (Powered)', N'10004123'),
(2740, N'Musical Instrument Accessories Other', N'10004128'),
(2741, N'Musical Instrument Cases/Bags/Covers', N'10004121'),
(2742, N'Musical Instrument Cleaning Products', N'10004122'),
(2743, N'Musical Instrument Holders/Stands/Lyres', N'10004124'),
(2733, N'Lubricants/Protective Compounds Storage Variety Packs', N'10005280'),
(2720, N'Rodents', N'10005455'),
(2719, N'Reptiles', N'10005466'),
(2718, N'Primates', N'10005459'),
(2695, N'Sunshine Recording Equipment – Powered', N'10003435'),
(2696, N'Thermometers – Garden – Non Powered', N'10003440'),
(2697, N'Thermometers – Garden – Powered', N'10005319'),
(2698, N'Wind Socks/Weather Vanes', N'10003446'),
(2699, N'Annelids (Worms)', N'10005448'),
(2700, N'Arachnids (Spiders/Scorpions)', N'10005447'),
(2701, N'Coral/Sea Anemone', N'10005454'),
(2702, N'Insects', N'10005446'),
(2703, N'Invertebrates Other', N'10005475'),
(2704, N'Molluscs', N'10005449'),
(2705, N'Sea Stars/Sea Urchins', N'10005452'),
(2706, N'Amphibians', N'10005458'),
(2707, N'Birds', N'10005457'),
(2708, N'Bovine (Cattle)', N'10005461'),
(2709, N'Canine (Dogs)', N'10005625'),
(2710, N'Caprine (Goats)', N'10005462'),
(2711, N'Cetaceans (Whales/Dolphins/Porpoises)', N'10005469'),
(2712, N'Equine (Horses/Donkeys)', N'10005463'),
(2713, N'Feline (Cats)', N'10005460'),
(2714, N'Fishes', N'10005456'),
(2715, N'Lagomorphs (Hares/Rabbits)', N'10005468'),
(2716, N'Marsupials', N'10005467'),
(2717, N'Ovine (Sheep)', N'10005465'),
(2744, N'Percussion Musical Instrument Accessories (Non Powered)', N'10004118'),
(2745, N'String Musical Instrument Accessories (Non Powered)', N'10004119');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2746, N'Woodwind Musical Instrument Accessories (Non Powered)', N'10004120'),
(2747, N'Brasswind Musical Instruments (Non Powered)', N'10000933'),
(2775, N'Body Bags/Waist Bags', N'10001094'),
(2776, N'Briefcases', N'10001095'),
(2777, N'Handbags/Shoulder Bags', N'10001096'),
(2778, N'Key Rings', N'10005756'),
(2779, N'Luggage/Personal Bags/Umbrellas Accessories', N'10001097'),
(2780, N'Luggage/Suitcases/Garment Carriers', N'10001099'),
(2781, N'Personal Bags/Luggage/Umbrellas Other', N'10001390'),
(2782, N'Personal Bags/Luggage/Umbrellas Variety Packs', N'10001391'),
(2783, N'Personal Carrier Bags (Disposable)', N'10005817'),
(2784, N'Rucksacks/Backpacks/Holdalls', N'10001100'),
(2785, N'Shopping Trolley Bags', N'10001101'),
(2786, N'Toiletry Bags/Vanity Cases', N'10005200'),
(2787, N'Umbrellas – Personal', N'10001102'),
(2788, N'Wallets/Purses/Travel Document Holders', N'10001103'),
(2789, N'Watch Accessories/Replacement Parts', N'10001104'),
(2790, N'Watches', N'10001105'),
(2791, N'Watches Other', N'10001392'),
(2792, N'Aquarium Aids/Accessories (Non Powered)', N'10000516'),
(2793, N'Aquarium Aids/Accessories (Powered)', N'10000656'),
(2794, N'Pet Accessories Other', N'10000736'),
(2795, N'Pet Accessory Variety Packs', N'10000659'),
(2796, N'Pet Attire', N'10000643'),
(2797, N'Pet Food/Drink Dispenser (Powered)', N'10000660'),
(2774, N'Personal Accessories Variety Packs', N'10001389'),
(2694, N'Rain Gauges – Powered', N'10005320'),
(2773, N'Tiaras', N'10001093'),
(2771, N'Pendants', N'10001091'),
(2748, N'Keyboards/Pianos (Non Powered)', N'10000934'),
(2749, N'Musical Instruments Other (Non Powered)', N'10001375'),
(2750, N'Percussion Musical Instruments (Non Powered)', N'10000935'),
(2751, N'String Musical Instruments (Non Powered)', N'10000936'),
(2752, N'Woodwind Musical Instruments (Non Powered)', N'10000937'),
(2753, N'Brasswind Musical Instruments (Powered)', N'10000938'),
(2754, N'Keyboards/Pianos (Powered)', N'10000940'),
(2755, N'Musical Instrument Aids (Powered)', N'10000939'),
(2756, N'Musical Instruments Other (Powered)', N'10001377'),
(2757, N'Percussion Musical Instruments (Powered)', N'10000941'),
(2758, N'String Musical Instruments (Powered)', N'10000942'),
(2759, N'Woodwind Musical Instruments (Powered)', N'10000943'),
(2760, N'Musical Instruments/Accessories Variety Packs', N'10004126');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2761, N'Anklets', N'10001083'),
(2762, N'Bracelets', N'10001084'),
(2763, N'Brooches', N'10001085'),
(2764, N'Cuff-links', N'10001086'),
(2765, N'Earrings/Body-piercing Jewellery', N'10001087'),
(2766, N'Jewellery Boxes/Pouches', N'10001088'),
(2767, N'Jewellery Other', N'10001387'),
(2768, N'Jewellery Replacement Parts', N'10001089'),
(2769, N'Jewellery Variety Packs', N'10001388'),
(2770, N'Necklaces/Necklets', N'10001090'),
(2772, N'Rings', N'10001092'),
(2693, N'Rain Gauges – Non Powered', N'10003447'),
(2692, N'Pyranometers/Solarimeters – Powered', N'10003433'),
(2691, N'Psychrometers – Powered', N'10003432'),
(2614, N'Outdoor Lamps/Torches/Lanterns – Non Powered', N'10005216'),
(2615, N'Outdoor Lamps/Torches/Lanterns – Powered', N'10005215'),
(2616, N'Arbours/Bowers', N'10003414'),
(2617, N'Cold Frames/Propagators/Cloches', N'10003421'),
(2618, N'Conservatories', N'10003415'),
(2619, N'Gazebos', N'10003412'),
(2620, N'Greenhouse Frames', N'10003890'),
(2621, N'Greenhouses (Complete)', N'10003409'),
(2622, N'Lawn/Garden Outdoor Structures Other', N'10003418'),
(2623, N'Lawn/Garden Outdoor Structures Variety Packs', N'10003891'),
(2624, N'Pagodas (Lawn/Garden)', N'10003416'),
(2625, N'Plants/Fauna Tunnels', N'10003859'),
(2626, N'Sheds', N'10003411'),
(2627, N'Wildlife Habitat', N'10006847'),
(2628, N'Garden Water Features', N'10003215'),
(2629, N'Garden/Water Feature Ornaments', N'10003315'),
(2630, N'Lawn/Garden Pools/Ponds/Water Features Other', N'10003225'),
(2631, N'Pond/Water Feature Aerators', N'10003220'),
(2632, N'Pond/Water Feature Foggers', N'10003218'),
(2633, N'Pool Supplies', N'10005253'),
(2634, N'Pool/Pond/Water Feature Drainage Pipes', N'10003222'),
(2635, N'Pool/Pond/Water Feature Filters (Powered)', N'10003216'),
(2636, N'Pool/Pond/Water Feature Protective Covers', N'10003223'),
(2613, N'Lawn/Garden Lighting Other', N'10005218'),
(2637, N'Pool/Pond/Water Feature Shells/Liners', N'10003213'),
(2612, N'Tampers (Non Powered)', N'10003395'),
(2610, N'Shovels/Spades', N'10003390'),
(2587, N'Lawn/Garden Furnishings Variety Packs', N'10003252');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2588, N'Mail/Post Boxes (Lawn/Garden)', N'10005361'),
(2589, N'Marquees', N'10003417'),
(2590, N'Plant Holders', N'10003313'),
(2591, N'Umbrellas/Parasols', N'10005219'),
(2592, N'Axes', N'10003383'),
(2593, N'Bulb Planters', N'10003398'),
(2594, N'Digging Bars', N'10003846'),
(2595, N'Edgers (Non Powered)', N'10003389'),
(2596, N'Garden Carts (Non Powered)', N'10003404'),
(2597, N'Garden Shears (Non Powered)', N'10003379'),
(2598, N'Harrows', N'10003386'),
(2599, N'Lawn Aerators (Non Powered)', N'10003393'),
(2600, N'Lawn Bags', N'10003403'),
(2601, N'Lawn Sweeps/Spreaders (Non Powered)', N'10003377'),
(2602, N'Lawn/Garden Hand Tools Other', N'10003865'),
(2603, N'Lawn/Garden Hand Tools Variety Packs', N'10003866'),
(2604, N'Loppers', N'10003380'),
(2605, N'Mauls', N'10003385'),
(2606, N'Post Hole Diggers (Non Powered)', N'10003844'),
(2607, N'Pruners/Secateurs', N'10003381'),
(2608, N'Rakes', N'10003399'),
(2609, N'Seed Starters', N'10003405'),
(2611, N'Sickles/Scythes/Snaths', N'10003384'),
(2798, N'Pet Food/Drink Dispensers (Non Powered)', N'10000642'),
(2638, N'Pool/Pond/Water Feature UV Clarifiers/Sterilizers', N'10003219'),
(2640, N'Chain Saws (Powered)', N'10003359'),
(2668, N'Garden Water Storage Supplies', N'10003268'),
(2669, N'Hose Connectors', N'10003255'),
(2670, N'Hose Storage – Mobile', N'10003257'),
(2671, N'Hose Storage – Stationary', N'10003256'),
(2672, N'Hoses', N'10003254'),
(2673, N'Irrigation Systems', N'10003264'),
(2674, N'Irrigation Timers/Controllers', N'10003276'),
(2675, N'Lawn/Garden Watering Equipment Other', N'10003274'),
(2676, N'Lawn/Garden Watering Equipment Variety Packs', N'10003272'),
(2677, N'Sprinklers/Sprayers/Misters (Hose End)', N'10003262'),
(2678, N'Watering Cans', N'10003267'),
(2679, N'Anemometers – Non Powered', N'10003430'),
(2680, N'Anemometers – Powered', N'10005318'),
(2681, N'Barographs – Non Powered', N'10003443'),
(2682, N'Barometers – Non Powered', N'10003441'),
(2683, N'Combination Weather Measuring/Monitoring Equipment – Non Powered', N'10003444');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2684, N'Combination Weather Measuring/Monitoring Equipment – Powered', N'10005316'),
(2685, N'Evaporimeters/Atmometers – Powered', N'10003434'),
(2686, N'Hygrometers – Non-Powered', N'10003437'),
(2687, N'Hygrometers – Powered', N'10005323'),
(2688, N'Lawn/Garden Weather Monitoring/Observation Other', N'10003452'),
(2689, N'Lawn/Garden Weather Monitoring/Observation Variety Packs', N'10003453'),
(2690, N'Light Meters – Powered', N'10003436'),
(2667, N'Garden Water Pumps', N'10003857'),
(2639, N'Brush Cutters/String Trimmers/Edgers (Powered)', N'10003355'),
(2666, N'Outdoor Bins', N'10003314'),
(2664, N'Garden Incinerators', N'10003400'),
(2641, N'Chippers/Shredders/Mulchers (Powered)', N'10003351'),
(2642, N'Cultivators/Tillers/Rotary Hoes (Powered)', N'10003373'),
(2643, N'Earth Augers (Powered)', N'10003365'),
(2644, N'Garden Power Tools Other', N'10003408'),
(2645, N'Garden Vacuums/Blowers', N'10003338'),
(2646, N'Hedge Trimmers (Powered)', N'10003870'),
(2647, N'Lawn Scarifiers/Aerators (Powered)', N'10003347'),
(2648, N'Lawn/Garden Power Tools Replacement Parts/Accessories', N'10003402'),
(2649, N'Log Splitters (Powered)', N'10003367'),
(2650, N'Post Hole Diggers (Powered)', N'10003861'),
(2651, N'Pressure Washers (Powered)', N'10003375'),
(2652, N'Pruners (Powered)', N'10003843'),
(2653, N'Stump Grinders/Pullers (Powered)', N'10003368'),
(2654, N'Tampers (Powered)', N'10003370'),
(2655, N'Weed Burners (Powered)', N'10003401'),
(2656, N'Ground Cover/Landscaping/Mulching Fabrics', N'10005729'),
(2657, N'Lawn/Garden Soil/Soil Amendments Other', N'10004110'),
(2658, N'Topsoil', N'10003236'),
(2659, N'Lawn/Garden Testing Diagnostic Equipment Other', N'10003887'),
(2660, N'Water/Soil Testing Equipment (Non Powered)', N'10003238'),
(2661, N'Concrete Tiles  - Outdoor Ground', N'10006787'),
(2662, N'Natural Stone Tiles  - Outdoor Ground', N'10006789'),
(2663, N'Wooden Tiles - Outdoor Ground', N'10006786'),
(2665, N'Lawn/Garden Waste Disposal Other', N'10003311'),
(2799, N'Pet Housing/Bedding (Disposable)', N'10000572'),
(2800, N'Pet Housing/Bedding (Non Disposable)', N'10000662'),
(2801, N'Pet Toys (Non Powered)', N'10000641'),
(2937, N'Weather/Natural Disaster Safety Product Variety Packs', N'10005395'),
(2938, N'Burglar Alarms', N'10005396'),
(2939, N'Gas/Heat/Smoke Detectors', N'10005397'),
(2940, N'Stanchions', N'10006231');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2941, N'Access Control Security Systems', N'10005398'),
(2942, N'Door Chains', N'10005401'),
(2943, N'Door/Gate Entry Intercoms', N'10005399'),
(2944, N'Door/Gate Viewers', N'10005402'),
(2945, N'Door/Gate/Window Bolts/Locks/Keys', N'10005400'),
(2946, N'Door/Window/Perimeter Security Products Variety Packs', N'10005406'),
(2947, N'Security Doors/Gates', N'10005403'),
(2948, N'Window Burglar Bars/Panels/Shutters', N'10005405'),
(2949, N'Fire Blankets', N'10005407'),
(2950, N'Fire Extinguishers – Pressurised', N'10005408'),
(2951, N'Fire Hoses', N'10005409'),
(2952, N'Home/Business Fire Extinguishers Variety Packs', N'10005410'),
(2953, N'Bugging/Debugging Equipment', N'10005411'),
(2954, N'Exterior Convex Mirrors', N'10005709'),
(2955, N'Home/Business Surveillance Equipment Variety Packs', N'10005415'),
(2956, N'Light/Motion/Sound Sensors', N'10005412'),
(2957, N'Security Lights', N'10005413'),
(2958, N'Surveillance Cameras/Video Recorders', N'10005414'),
(2959, N'Safes', N'10005416'),
(2936, N'Transponders', N'10005394'),
(2960, N'Body Alarms', N'10005373'),
(2935, N'Storm Shelters', N'10005393'),
(2933, N'Marine Navigation Software', N'10005873'),
(2910, N'Helmets – Non Powered', N'10005110'),
(2911, N'Helmets – Powered', N'10005109'),
(2912, N'Protective Personal Aids Other', N'10005116'),
(2913, N'Protective Personal Aids Variety Packs', N'10005117'),
(2914, N'Safety Glasses/Goggles', N'10003586'),
(2915, N'Baby Harnesses/Reins', N'10000796'),
(2916, N'Baby Play Pens/Dens', N'10000788'),
(2917, N'Baby Safety Monitoring (Non Powered)', N'10000634'),
(2918, N'Baby Safety Monitoring (Powered)', N'10000791'),
(2919, N'Baby Safety Protection (Non Powered)', N'10000503'),
(2920, N'Baby Safety/Security/Surveillance - Other', N'10006820'),
(2921, N'Baby Safety/Security/Surveillance Variety Packs', N'10006818'),
(2922, N'Fire Escape Chutes/Ladders', N'10005384'),
(2923, N'Fire Retardants/Suppressants', N'10005383'),
(2924, N'Public Fire Alarms', N'10005385'),
(2925, N'Smoke Hoods/Respirators', N'10005386'),
(2926, N'Air/Fog Horns', N'10005388'),
(2927, N'Barricade Safety Tapes', N'10005725'),
(2928, N'Lifebelts/Life-Jackets/Lifesuits', N'10005389');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2929, N'Liferafts/Life-Buoys/Flotation Cushions', N'10005390'),
(2930, N'Lightning Detectors – Powered', N'10003427'),
(2931, N'Lightning Rods/Accessories', N'10005391'),
(2932, N'Marine Electronic Chartplotters', N'10005872'),
(2934, N'Sandbags/Flood-guards', N'10005392'),
(2909, N'Hearing Protection – Powered', N'10005107'),
(2961, N'Emergency Survival Blankets/Sleeping Bags', N'10005472'),
(2963, N'Key-ring Alarms', N'10005375'),
(2991, N'Cycles (Powered)', N'10005815'),
(2992, N'Fishfinders', N'10005870'),
(2993, N'Fishing Bait/Flies', N'10001915'),
(2994, N'Fishing Floats', N'10001917'),
(2995, N'Fishing Hooks', N'10001916'),
(2996, N'Fishing Line/Gut', N'10001920'),
(2997, N'Fishing Nets', N'10001918'),
(2998, N'Fishing Reels', N'10001914'),
(2999, N'Fishing Rod Accessories', N'10001921'),
(3000, N'Fishing Rods/Poles', N'10001913'),
(3001, N'Fishing/Angling Sports Equipment Other', N'10001923'),
(3002, N'Gymnastics Apparatus', N'10001827'),
(3003, N'Gymnastics Sports Equipment Other', N'10001830'),
(3004, N'Rhythm Gymnastics Equipment', N'10001826'),
(3005, N'Game Lures/Decoys/Callers', N'10001880'),
(3006, N'Hunting Field Dressing Equipment', N'10001883'),
(3007, N'Hunting Sports Aids Other', N'10001886'),
(3008, N'Kites', N'10001831'),
(3009, N'Kiting/Parachuting Boards/Buggies (Non Powered)', N'10001834'),
(3010, N'Kiting/Parachuting Sports Equipment – Replacement Parts/Accessories', N'10001835'),
(3011, N'Kiting/Parachuting Sports Equipment Other', N'10001838'),
(3012, N'Parachutes', N'10001832'),
(3013, N'Exercise Machines (Non Powered)', N'10001815'),
(2990, N'Cycles (Non Powered)', N'10001810'),
(2962, N'Emergency Whistles', N'10005374'),
(2989, N'Cycles – Replacement Parts', N'10001811'),
(2987, N'Cycle Anti-theft Device', N'10006392'),
(2964, N'Personal Luggage Alarms', N'10005376'),
(2965, N'Personal Safety Devices Variety Packs', N'10005382'),
(2966, N'Personal Safety Flares/Signals', N'10005377'),
(2967, N'Personal Safety Lights', N'10005378'),
(2968, N'Remote Controlled Vehicles', N'10006850'),
(2969, N'Remotely Controlled Vehicle Replacement Parts and Accessories', N'10006851'),
(2970, N'Self-defence Sprays', N'10005379');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2971, N'Stun Guns', N'10005380'),
(2972, N'Wearable Wireless Webcams (Inverse Surveillance)', N'10005381'),
(2973, N'Safety/Security/Surveillance Variety Packs', N'10005418'),
(2974, N'Baby Carrier', N'10000502'),
(2975, N'Baby Carry Cots/Baskets/Cradles', N'10000795'),
(2976, N'Baby Cot/Basket – Travel', N'10000794'),
(2977, N'Baby Door Bouncers', N'10000802'),
(2978, N'Baby Exercisers/Transportation Other', N'10000805'),
(2979, N'Baby Swings', N'10000803'),
(2980, N'Pram/Pushchair/Stroller Accessories', N'10000797'),
(2981, N'Prams/Pushchairs/Strollers', N'10000793'),
(2982, N'Combat Sports Equipment Other', N'10004096'),
(2983, N'Fencing Sports Equipment (Non Powered)', N'10004112'),
(2984, N'Fencing Sports Equipment (Powered)', N'10004098'),
(2985, N'Martial Arts Sports Equipment', N'10001807'),
(2986, N'Punching/Kicking Training Aids', N'10001806'),
(2988, N'Cycle Sports Equipment Variety Packs', N'10001812'),
(3015, N'Free Weights/Dumb-bells', N'10001816'),
(2908, N'Hearing Protection – Non Powered', N'10005108'),
(2906, N'Face Shields/Guards', N'10005112'),
(2829, N'Duct Boosters', N'10003996'),
(2830, N'Fans – Ceiling', N'10003995'),
(2831, N'Fans – Extractor', N'10003998'),
(2832, N'Fans – Window/Exhaust', N'10004064'),
(2833, N'Backflow Preventer Parts/Accessories', N'10005865'),
(2834, N'Backflow Test Kits', N'10005863'),
(2835, N'Bath Lifts', N'10002624'),
(2836, N'Bath Seats', N'10004027'),
(2837, N'Bath/Shower Caddies – Fixed', N'10004032'),
(2838, N'Bathroom Fittings Variety Packs', N'10002627'),
(2839, N'Grab Bars', N'10004028'),
(2840, N'Hand Dryers', N'10006232'),
(2841, N'Shower Safety Strips', N'10004026'),
(2842, N'Shower Thermo Alarms', N'10002623'),
(2843, N'Soap/Lotion/Sanitizer Dispensers', N'10004034'),
(2844, N'Toilet Seats/Lids', N'10004062'),
(2845, N'Towel Bars/Hooks/Rings – Fixed', N'10004033'),
(2846, N'Central Heating Replacement Parts/Accessories', N'10002660'),
(2847, N'Fireplace Fuel Storage', N'10006402'),
(2848, N'Fireplace Screens', N'10006401'),
(2849, N'Fireplaces/Fireplace Surrounds/Mantels', N'10005478'),
(2850, N'Heating Equipment Variety Packs', N'10002662');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2851, N'Heating System Controls', N'10002653'),
(2828, N'Air Purifiers/Ionisers – Fixed', N'10003988'),
(2852, N'Household Boilers/Furnaces/Tank Water Heaters', N'10002658'),
(2827, N'Air Monitors', N'10006274'),
(2825, N'Air Dehumidifiers – Fixed', N'10003990'),
(2802, N'Pet Toys (Powered)', N'10000661'),
(2803, N'Pet Training/Control Aids/Accessories (Non Powered)', N'10000640'),
(2804, N'Pet Training/Control Aids/Accessories (Powered)', N'10000652'),
(2805, N'Terrarium Aids/Accessories (Non Powered)', N'10006843'),
(2806, N'Terrarium Aids/Accessories (Powered)', N'10006844'),
(2807, N'Pet Care Variety Packs', N'10000653'),
(2808, N'Pet Nutritional Supplements', N'10000513'),
(2809, N'Pet Nutritional Supplements Other', N'10000737'),
(2810, N'Pet Parasite Treatment', N'10000515'),
(2811, N'Pet Grooming Aids', N'10000508'),
(2812, N'Pet Hygiene/Sanitary Protection', N'10000510'),
(2813, N'Pet Welfare/Hygiene Other', N'10000738'),
(2814, N'Pet Care/Food Variety Packs', N'10000654'),
(2815, N'Pet Drinks (Frozen)', N'10000506'),
(2816, N'Pet Drinks (Perishable)', N'10000523'),
(2817, N'Pet Drinks (Shelf Stable)', N'10000524'),
(2818, N'Pet Food (Frozen)', N'10000507'),
(2819, N'Pet Food (Perishable)', N'10000521'),
(2820, N'Pet Food (Shelf Stable)', N'10000522'),
(2821, N'Pet Food/Drinks Variety Packs', N'10000663'),
(2822, N'Air Conditioners/Coolers – Fixed', N'10003982'),
(2823, N'Air Conditioning Equipment – Multifunction – Fixed', N'10004063'),
(2824, N'Air Conditioning/Cooling/Ventilation Equipment Replacement Parts/Accessories', N'10003984'),
(2826, N'Air Humidifiers – Fixed', N'10003993'),
(2907, N'Hard Hats/Caps', N'10005111'),
(2853, N'Immersion Heaters', N'10002657'),
(2855, N'Room Heaters', N'10005717'),
(2883, N'De-scalers (DIY)', N'10004006'),
(2884, N'Scale Inhibitors', N'10002649'),
(2885, N'Water Filtration Machines/Systems', N'10004016'),
(2886, N'Water Meters', N'10004012'),
(2887, N'Water Softeners (DIY)', N'10004008'),
(2888, N'Water Storage/Treatment – Accessories/Replacement Parts', N'10002650'),
(2889, N'Water Storage/Treatment Variety Packs', N'10002652'),
(2890, N'Water Tanks', N'10002646'),
(2891, N'Water Treatments (DIY)', N'10002648'),
(2892, N'Pipes/Tubing', N'10004054');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2893, N'Pipes/Tubing – Accessories/Replacement Parts', N'10004057'),
(2894, N'Pipes/Tubing Connectors', N'10004022'),
(2895, N'Pipes/Tubing Flanges', N'10005867'),
(2896, N'Pipes/Tubing Supply Variety Packs', N'10004058'),
(2897, N'Pipes/Tubing Valves/Fittings', N'10004024'),
(2898, N'Pumps', N'10004055'),
(2899, N'Absorbents (DIY)', N'10005626'),
(2900, N'Antifatigue Aids (DIY)', N'10005627'),
(2901, N'Antislip Aids (DIY)', N'10005628'),
(2902, N'Protective Collective Aids Other', N'10005646'),
(2903, N'Safety Nets/Curtains/Barriers', N'10005630'),
(2904, N'Environmental Respiratory Protection – Non Powered', N'10005106'),
(2905, N'Environmental Respiratory Protection – Powered', N'10005105'),
(2882, N'Waste Traps', N'10005480'),
(2854, N'Radiators', N'10002654'),
(2881, N'Plungers', N'10003565'),
(2879, N'Urinals', N'10002587'),
(2856, N'Solar Power Stations', N'10005875'),
(2857, N'Tankless Water Heaters', N'10005479'),
(2858, N'Thermostats', N'10004002'),
(2859, N'Underfloor Heating Systems', N'10004003'),
(2860, N'Plumbing/Heating Ventilation/Air Conditioning Variety Packs', N'10003994'),
(2861, N'Basin/Sink Pedestals', N'10002609'),
(2862, N'Basins/Sinks', N'10002592'),
(2863, N'Bathroom Suites', N'10002610'),
(2864, N'Bathtub/Shower Doors', N'10002600'),
(2865, N'Bathtub/Shower Enclosure Panels', N'10002601'),
(2866, N'Bathtub/Shower Modules', N'10002590'),
(2867, N'Bathtubs – Jetted (Hot Tubs/Spas)', N'10002596'),
(2868, N'Bathtubs – Soaking', N'10002595'),
(2869, N'Bidets', N'10002585'),
(2870, N'Faucets/Taps', N'10002602'),
(2871, N'Sanitary Ware – Replacement Parts/Accessories', N'10002612'),
(2872, N'Sanitary Ware Variety Packs', N'10002614'),
(2873, N'Shower Heads', N'10002608'),
(2874, N'Shower Pans/Trays', N'10002599'),
(2875, N'Sink/Base Combinations', N'10002593'),
(2876, N'Toilet/Urinal Cisterns', N'10002589'),
(2877, N'Toilets', N'10002586'),
(2878, N'Urinal Partitions', N'10002588'),
(2880, N'Macerators', N'10002611'),
(1723, N'Winter Melons or Odourless Muskmelons', N'10006827');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (2039, N'Hot Dog Rollers', N'10005704'),
(1721, N'Other Melons', N'10006348'),
(568, N'Keys', N'10003914'),
(569, N'Letter Boxes', N'10002578'),
(570, N'Mezzanine/Attic Ladders', N'10002515'),
(571, N'Storm/Screen Door Replacement Hardware', N'10003916'),
(572, N'Cat/Dog Flaps', N'10002577'),
(573, N'Door Accessories', N'10005471'),
(574, N'Doors – Bulkhead (Basement)', N'10003921'),
(575, N'Doors – Exterior', N'10002570'),
(576, N'Doors – Garage', N'10002568'),
(577, N'Doors – Interior', N'10002567'),
(567, N'House identification – Numbers/Letters', N'10002579'),
(578, N'Doors – Patio', N'10002569'),
(580, N'Doors Variety Packs', N'10003924'),
(581, N'Gate/Garage Door Opening Systems', N'10005673'),
(582, N'Anchors/Wall Plugs (Fixings/Fasteners)', N'10003179'),
(583, N'Bearings/Bushings', N'10003170'),
(584, N'Bolts/Threaded Rods', N'10003185'),
(585, N'Brackets/Braces', N'10003186'),
(586, N'Catches (Fixings/Fasteners)', N'10003187'),
(587, N'Fixings/Fasteners Hardware Accessories', N'10005670'),
(588, N'Fixings/Fasteners Hardware Other', N'10003194'),
(589, N'Hooks (Fixings/Fasteners)', N'10003171'),
(579, N'Doors – Storm/Screen Combination', N'10003920'),
(566, N'Hinges – Door', N'10003191'),
(565, N'Door Weather Excluders', N'10002575'),
(564, N'Door Thresholds', N'10003906'),
(541, N'Curtain Holdbacks', N'10005688'),
(542, N'Curtain Hooks/Rings', N'10003198'),
(543, N'Curtain Parts/Accessories Other', N'10003201'),
(544, N'Curtain Poles/Rods', N'10003196'),
(545, N'Curtain Rod Brackets', N'10003199'),
(1722, N'Watermelons', N'10006037'),
(547, N'Curtain Tracks', N'10003197'),
(548, N'Balustrade/Railing Systems – Non Wood', N'10003961'),
(549, N'Balustrade/Railing Systems – Wood', N'10003962'),
(550, N'Deck Drainage Systems', N'10002672'),
(551, N'Deck Railing Parts', N'10002668'),
(552, N'Deck Railing Systems – Composite', N'10002671'),
(553, N'Decking – Composite', N'10002669'),
(554, N'Decking Accessories', N'10002670');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (555, N'Decking/Railing Other', N'10002673'),
(556, N'Stair Railing Systems – Non Wood', N'10003960'),
(557, N'Stair Railing Systems – Wood', N'10003959'),
(558, N'Bells/Chimes/Buzzers', N'10005560'),
(559, N'Door Closers', N'10002574'),
(560, N'Door Handles/Knobs/Levers', N'10002573'),
(561, N'Door Hardware Other', N'10003918'),
(562, N'Door Knockers', N'10002581'),
(563, N'Door Plates', N'10002572'),
(590, N'Mounting Rails', N'10006794'),
(591, N'Nuts (Fixings/Fasteners)', N'10003184'),
(592, N'Rings/Grommets', N'10003166'),
(593, N'Rivets (Fixings/Fasteners)', N'10003190'),
(621, N'Lawn/Ground-Level Drainage Parts/Fittings', N'10002663'),
(622, N'Insulation – Batts/Rolls/Blankets', N'10002454'),
(623, N'Insulation – Loose Fill/Spray Foam', N'10002456'),
(624, N'Insulation – Radiant Barriers/Heat Shields', N'10005342'),
(625, N'Insulation – Rigid Foam Board (Interior)', N'10002455'),
(626, N'Insulation Other', N'10002460'),
(627, N'Insulation Supports/Anchors', N'10005345'),
(628, N'Insulation Variety Packs', N'10002461'),
(629, N'Beams (Structural)', N'10003927'),
(630, N'Engineered Wood (Dimension/Structural)', N'10002537'),
(631, N'Gypsum/Cement Board', N'10002540'),
(632, N'Hardwood Lumber (Dimension/Structural)', N'10002535'),
(633, N'Laths', N'10005721'),
(634, N'Lumber/Wood Panel/Gypsum Variety Packs', N'10003933'),
(635, N'Plywood/OSB', N'10002538'),
(636, N'Poles/Pilings/Rods', N'10005424'),
(637, N'Softwood Board', N'10005355'),
(638, N'Softwood Lumber (Dimension/Structural)', N'10002536'),
(639, N'Iron on Edging Strip/Banding', N'10006793'),
(640, N'Jambs (Mouldings/Millwork)', N'10005428'),
(641, N'Millwork – Ornaments', N'10003939'),
(642, N'Mouldings – Non Wood', N'10003934'),
(643, N'Mouldings – Wood', N'10003935'),
(620, N'Guttering/Drainage Other', N'10002666'),
(540, N'Building Products - Other', N'10006895'),
(619, N'Guttering Parts/Fittings', N'10002665'),
(617, N'Drain Covers (Guttering/Drainage)', N'10005668'),
(594, N'Ropes/Chains/Cables (Fixings/Fasteners)', N'10003167'),
(595, N'Screws', N'10003181');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (596, N'Springs', N'10003168'),
(597, N'Staples (Fixings/Fasteners)', N'10003183'),
(598, N'Tubing', N'10003173'),
(599, N'Washers (Fixings/Fasteners)', N'10003180'),
(600, N'Entrance Grid/Mat Frame', N'10006901'),
(601, N'Flooring – Carpet', N'10002446'),
(602, N'Flooring – Ceramic/Porcelain Tiles', N'10002443'),
(603, N'Flooring – Cork/Bamboo', N'10002449'),
(604, N'Flooring – Engineered Wood', N'10005370'),
(605, N'Flooring – Laminate', N'10002451'),
(606, N'Flooring – Solid Wood', N'10002447'),
(607, N'Flooring – Stone/Marble', N'10002450'),
(608, N'Flooring - Underlay', N'10006841'),
(609, N'Flooring – Vinyl/Rubber/Linoleum', N'10002448'),
(610, N'Flooring Accessories', N'10002444'),
(611, N'Flooring Other', N'10002452'),
(612, N'Shims/Spacers', N'10002532'),
(613, N'Glass', N'10002584'),
(614, N'Glass Block (Grid Systems)', N'10003925'),
(615, N'Channel (Guttering/Drainage)', N'10006902'),
(616, N'Down Spout Parts/Fittings', N'10003956'),
(618, N'Drop Outlets (Guttering/Drainage)', N'10003955'),
(539, N'Stucco', N'10002527'),
(538, N'Stone – Stone Pavers', N'10002518'),
(537, N'Stone – Building Stone', N'10003894'),
(460, N'Feminine Hygiene – Tampons', N'10000320'),
(461, N'Feminine Hygiene – Towels/Pads', N'10000376'),
(462, N'Feminine/Nursing Hygiene Other', N'10000785'),
(463, N'Nursing Hygiene Accessories', N'10000362'),
(464, N'Antiperspirants/Deodorants', N'10000338'),
(465, N'Cotton Wool Products', N'10000335'),
(466, N'Ear/Nasal Care', N'10000341'),
(467, N'Facial Tissue/Handkerchiefs (Disposable)', N'10000485'),
(468, N'General Personal Hygiene Other', N'10000786'),
(469, N'Toilet Paper', N'10000375'),
(470, N'Breath Fresheners/Mouth Rinses', N'10000536'),
(471, N'Dental Cleansing', N'10000383'),
(472, N'Denture/Orthodontic – Care', N'10000336'),
(473, N'Denture/Orthodontic – Cleansing', N'10000337'),
(474, N'Oral Care – Accessories', N'10000363'),
(475, N'Oral Care – Aids (Non Powered)', N'10000384'),
(476, N'Oral Care – Aids (Powered)', N'10000781');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (477, N'Oral Care Centre – Brush/Cleanser/Storage (Powered)', N'10005839'),
(478, N'Oral Hygiene – Replacement Parts', N'10000782'),
(479, N'Oral Hygiene Other', N'10000783'),
(480, N'Personal Hygiene Products Variety Packs', N'10000712'),
(481, N'Penetration Accessories (Non Powered)', N'10006247'),
(482, N'Penetration Accessories (Powered)', N'10006246'),
(459, N'Feminine Hygiene – Panty Liners', N'10000483'),
(483, N'Suction Devices (Non Powered)', N'10006249'),
(458, N'Feminine Hygiene – Cups', N'10000482'),
(456, N'Baby Inserts/Pads', N'10000495'),
(433, N'Hair Products Variety Packs', N'10000676'),
(434, N'Bleaching/Lightening Products', N'10000329'),
(435, N'Depilation/Epilation (Non Powered)', N'10000340'),
(436, N'Depilation/Epilation (Powered)', N'10000830'),
(437, N'Hair Removal – Care', N'10000350'),
(438, N'Hair Removal/Masking Products – Replacement Parts', N'10000832'),
(439, N'Hair Removal/Masking Products Variety Packs', N'10000680'),
(440, N'Hair Removal/Shaving – Accessories', N'10000349'),
(441, N'Mirrors – Personal Care', N'10000679'),
(442, N'Shaving – Blades', N'10000369'),
(443, N'Shaving – Razors – Disposable (Non Powered)', N'10000370'),
(444, N'Shaving – Razors – Non Disposable (Non Powered)', N'10000730'),
(445, N'Shaving – Razors (Powered)', N'10000831'),
(446, N'Shaving Preparations', N'10000535'),
(447, N'Adult Incontinence – Pads', N'10000481'),
(448, N'Adult Incontinence – Supplies', N'10000321'),
(449, N'Adult Incontinence – Underwear (Disposable)', N'10000709'),
(450, N'Adult Incontinence – Underwear (Non Disposable)', N'10000710'),
(451, N'Adult Incontinence Other', N'10000784'),
(452, N'Baby Diapers (Disposable)', N'10000494'),
(453, N'Baby Diapers (Non Disposable)', N'10000728'),
(454, N'Baby Diapers Accessories', N'10000496'),
(455, N'Baby Diapers/Accessories Other', N'10006821'),
(457, N'Feminine Hygiene – Accessories', N'10000344'),
(644, N'Mouldings/Millwork/Stair Parts Other', N'10005431'),
(484, N'Suction Devices (Powered)', N'10006248'),
(486, N'Body Washing Other', N'10000813'),
(514, N'Abrasives Variety Packs', N'10003164'),
(515, N'Emery Cloths/Sheets', N'10003159'),
(516, N'Floor Screeds', N'10003766'),
(517, N'Mineral Abrasives', N'10003162'),
(518, N'Polishing Compound', N'10003765');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (519, N'Sandpaper', N'10003156'),
(520, N'Wire Brushes', N'10005715'),
(521, N'Access Covers/Panels', N'10006900'),
(522, N'Aggregate', N'10002521'),
(523, N'Asphalt/Concrete Patching', N'10003898'),
(524, N'Asphalt/Concrete/Masonry Other', N'10003904'),
(525, N'Asphalt/Concrete/Masonry Replacement Parts/Accessories', N'10005632'),
(526, N'Asphalt/Concrete/Masonry Variety Packs', N'10003903'),
(527, N'Brick/Block', N'10002525'),
(528, N'Cement', N'10002526'),
(529, N'Concrete Air-entraining Agents', N'10003901'),
(530, N'Concrete Colouring Agents/Dyes', N'10003900'),
(531, N'Concrete Mixes', N'10002522'),
(532, N'Lime (DIY)', N'10002529'),
(533, N'Mortar Mixes', N'10003902'),
(534, N'Plaster Mixes', N'10002528'),
(535, N'Plaster of Paris (Agent)', N'10003896'),
(536, N'Sand (DIY)', N'10003897'),
(513, N'Abrasives Replacement Parts-Accessories', N'10005124'),
(485, N'Bath Additives', N'10000328'),
(512, N'Abrasives Other', N'10003163'),
(510, N'Sunless Tanning (Powered)', N'10000809'),
(487, N'Cleansing/Washing Accessories – Personal', N'10000334'),
(488, N'Cleansing/Washing/Soap – Body', N'10000330'),
(489, N'Wipes – Personal', N'10000573'),
(490, N'After Shave Care', N'10000324'),
(491, N'After-Sun Moisturisers', N'10006275'),
(492, N'Anti-spot Aids (Non Powered)', N'10000327'),
(493, N'Anti-spot Aids (Powered)', N'10000806'),
(494, N'Cleansers/Cosmetics Removers (Non Powered)', N'10000332'),
(495, N'Cleansers/Cosmetics Removers (Powered)', N'10000808'),
(496, N'Cooling Face/Body Misters', N'10000719'),
(497, N'Exfoliants/Masks', N'10000342'),
(498, N'Lip Balms', N'10005727'),
(499, N'Skin Care – Replacement Parts', N'10000810'),
(500, N'Skin Care Variety Packs', N'10000721'),
(501, N'Skin Care/Moisturising Products', N'10000356'),
(502, N'Skin Drying Powder', N'10000374'),
(503, N'Toners/Astringents', N'10000484'),
(504, N'Skin Products Variety Packs', N'10000717'),
(505, N'Skin Tanning Products Other', N'10000814'),
(506, N'Sun Protection Products', N'10000373');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (507, N'Sun Tan Accelerator Products', N'10000388'),
(508, N'Sunless Tanning – Oral (Non Powered)', N'10000731'),
(509, N'Sunless Tanning – Topical (Non Powered)', N'10000355'),
(511, N'Abrasive Pads/Steel Wool', N'10003157'),
(645, N'Newel Posts', N'10002512'),
(646, N'Stair Replacement Parts/Fittings', N'10005425'),
(647, N'Stairs – Prefabricated', N'10002507'),
(783, N'Scratch Remover Kit/Repairs', N'10000556'),
(784, N'Surface Care Other', N'10000749'),
(785, N'Surface Care/Protection', N'10000434'),
(786, N'Cleaning/Hygiene Products Variety Packs', N'10000694'),
(787, N'Dispensers for Cleaning/Hygiene Products', N'10006215'),
(788, N'Insect/Pest Control – Barriers/Traps', N'10000411'),
(789, N'Insect/Pest/Allergen Control Other', N'10000754'),
(790, N'Insecticides/Pesticides/Rodenticides', N'10000435'),
(791, N'Non Personal Repellents', N'10000436'),
(792, N'Refuse / Waste Bins', N'10002125'),
(793, N'Refuse Bags', N'10001761'),
(794, N'Waste Storage Products - Other', N'10006817'),
(795, N'Waste Storage Products Variety Packs', N'10006815'),
(796, N'Belts/Braces/Cummerbunds', N'10001326'),
(797, N'Clothing Accessories Variety Packs', N'10001354'),
(798, N'Clothing Adornment/Floral Accessories/Badges/Buckles', N'10001331'),
(799, N'Clothing/Fashion Tape', N'10006903'),
(800, N'Handkerchiefs', N'10001327'),
(801, N'Handwear', N'10001328'),
(802, N'Headwear', N'10001329'),
(803, N'Neckwear', N'10001330'),
(804, N'Clothing Variety Packs', N'10002102'),
(805, N'Dresses', N'10001333'),
(782, N'Laundry Other', N'10000747'),
(806, N'Full Body Wear Variety Packs', N'10001355'),
(781, N'Laundry Dry Cleaning', N'10000444'),
(779, N'Laundry Colour Care', N'10000427'),
(756, N'Descalers', N'10000442'),
(757, N'Dish Care/Protection', N'10000445'),
(758, N'Dish Cleaning/Care – Automatic', N'10000406'),
(759, N'Dish Cleaning/Care – Hand', N'10000636'),
(760, N'Disinfectants', N'10000441'),
(761, N'Drain Treatments/Pipe Unblockers', N'10000423'),
(762, N'Food Treatments', N'10006233'),
(763, N'Mould/Mildew Removers', N'10000440');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (764, N'Paper Towels', N'10000447'),
(765, N'Sanitizers', N'10006234'),
(766, N'Stain Removers', N'10000443'),
(767, N'Surface Cleaners', N'10000405'),
(768, N'Toilet Cleaning Products', N'10000426'),
(769, N'Water Softeners', N'10000446'),
(770, N'Cleaning Variety Packs', N'10000702'),
(771, N'Air Fresheners/Deodorisers (Non Powered)', N'10000402'),
(772, N'Air Fresheners/Deodorisers (Powered)', N'10000696'),
(773, N'Fresheners – Fabric', N'10000740'),
(774, N'Fresheners/Deodorisers Other', N'10000745'),
(775, N'Detergent Boosters/Laundry Bleaches', N'10000743'),
(776, N'Fabric Finishers/Starch', N'10000742'),
(777, N'Fabric Protectors', N'10000741'),
(778, N'Fabric Softeners/Conditioners', N'10000744'),
(780, N'Laundry Detergents', N'10000424'),
(755, N'Cleaning Aids', N'10000397'),
(807, N'Overalls/Bodysuits', N'10001332'),
(809, N'Skirts', N'10001334'),
(837, N'Pantyhose/Stockings', N'10002425'),
(838, N'Petticoats/Underskirts/Slips', N'10002424'),
(839, N'Socks', N'10001348'),
(840, N'Suspenders/Garters', N'10002426'),
(841, N'Undershirts/Chemises/Camisoles', N'10001349'),
(842, N'Underwear Variety Packs', N'10001360'),
(843, N'Jackets/Blazers/Cardigans/Waistcoats', N'10001350'),
(844, N'Shirts/Blouses/Polo Shirts/T-shirts', N'10001352'),
(845, N'Sweaters/Pullovers', N'10001351'),
(846, N'Upper Body Wear/Tops Variety Packs', N'10001361'),
(847, N'Caller id Displays', N'10001174'),
(848, N'Communication Accessories Other', N'10001379'),
(849, N'Communication Headphones Replacement Parts/Accessories', N'10005745'),
(850, N'Communications Hands Free Kits/Headphones', N'10001181'),
(851, N'Digital Enhanced Cordless Telecommunications (DECT) Repeaters', N'10005740'),
(852, N'Mobile Phone Cases', N'10001178'),
(853, N'Mobile Phone Fascias', N'10001182'),
(854, N'Mobile Phone Radiation Guards', N'10001183'),
(855, N'Phone Holders', N'10001177'),
(856, N'Telephone Wipes', N'10005680'),
(857, N'Answering Machines', N'10001184'),
(858, N'Conferencing Systems', N'10001185'),
(859, N'Fax Machine Consumables', N'10005677');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (836, N'Pants/Briefs/Undershorts', N'10001347'),
(808, N'Lower Body Wear/Bottoms Variety Packs', N'10001356'),
(835, N'Full Body Underwear', N'10001346'),
(833, N'Sportswear Variety Packs', N'10001359'),
(810, N'Trousers/Shorts', N'10001335'),
(811, N'Baby Feeding – Bibs', N'10000732'),
(812, N'Protective Full Body Wear', N'10001394'),
(813, N'Protective Handwear', N'10001395'),
(814, N'Protective Lower Body Wear', N'10001397'),
(815, N'Protective Upper Body Wear', N'10001398'),
(816, N'Protective Wear Accessories', N'10003704'),
(817, N'Protective Wear Variety Packs', N'10003705'),
(818, N'Dressing Gowns', N'10001338'),
(819, N'Night Dresses/Shirts', N'10001339'),
(820, N'Sleep Headwear', N'10001340'),
(821, N'Sleep Trousers/Shorts', N'10001341'),
(822, N'Sleepwear Variety Packs', N'10001358'),
(823, N'Sportswear – Badges/Buckles', N'10004115'),
(824, N'Sportswear – Belts', N'10004114'),
(825, N'Sportswear – Full Body Wear', N'10001342'),
(826, N'Sportswear – Handwear', N'10003707'),
(827, N'Sportswear – Headwear', N'10003708'),
(828, N'Sportswear – Lower Body Wear', N'10001343'),
(829, N'Sportswear – Neckwear', N'10004113'),
(830, N'Sportswear - Other', N'10006840'),
(831, N'Sportswear – Upper Body Wear', N'10001344'),
(832, N'Sportswear Hosiery', N'10003709'),
(834, N'Bras/Basques/Corsets', N'10001345'),
(432, N'Hair Curlers/Rollers', N'10000829'),
(754, N'Cleaning Accessories', N'10000398'),
(752, N'Bleach', N'10000531'),
(675, N'Sealants/Fillers/Adhesives Other', N'10003210'),
(676, N'Tape (DIY)', N'10003206'),
(677, N'Exterior Trim – Corbels/Pediments', N'10003966'),
(678, N'Exterior Trim – Siding', N'10002677'),
(679, N'Exterior Trim – Siding Accessories', N'10005705'),
(680, N'Exterior Trim – Skirting/Underpinning', N'10005731'),
(681, N'Exterior Trim – Veneers', N'10003969'),
(682, N'Columns (Structural)', N'10002530'),
(683, N'Floor Trusses', N'10002533'),
(684, N'I-Beams', N'10002534'),
(685, N'Mobile Home Assembly/Set-up Equipment', N'10005732');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (686, N'Roof Trusses', N'10005659'),
(687, N'Structural Components/Assemblies Replacement Parts/Accessories', N'10003943'),
(688, N'Ceiling Coverings – Panneling/Tiles', N'10003980'),
(689, N'Ceiling Grid Systems', N'10003981'),
(690, N'Coping Stones', N'10006791'),
(691, N'Corner Guards', N'10005722'),
(692, N'Wall Coverings – Rolls', N'10002429'),
(693, N'Wall Coverings – Sheets/Panels/Slabs', N'10002433'),
(694, N'Wall Coverings – Tiles', N'10002431'),
(695, N'Wall/Ceiling Covering Accessories', N'10002432'),
(696, N'Wall/Ceiling Coverings Other', N'10002441'),
(697, N'Awnings – Non Powered', N'10005291'),
(674, N'Sealants', N'10003204'),
(698, N'Awnings – Powered', N'10002551'),
(673, N'Grout', N'10003203'),
(671, N'Fillers', N'10003205'),
(648, N'Air Hopper Guns/Sprayers', N'10005805'),
(649, N'Decorative (Faux) Painting Equipment', N'10005730'),
(650, N'Dust Sheets/Drop Sheets', N'10002490'),
(651, N'Household Paint Brushes/Rollers/Applicators', N'10005708'),
(652, N'Household Paints/Primers', N'10003874'),
(653, N'Paint Additives/Enhancers', N'10005655'),
(654, N'Paint/Stain Strainers', N'10005706'),
(655, N'Paint/Varnish Removers/Cleaners', N'10002501'),
(656, N'Painting Masking Paper/Film', N'10005724'),
(657, N'Painting Other', N'10002505'),
(658, N'Preservers/Preservatives', N'10005657'),
(659, N'Special Purpose Paints', N'10002462'),
(660, N'Trim Paints', N'10005687'),
(661, N'Wood Finish/Treatments/Coatings', N'10002466'),
(662, N'Roll Roofing', N'10002684'),
(663, N'Roof Coatings', N'10002688'),
(664, N'Roofing – Thatch', N'10003974'),
(665, N'Roofing Accessories', N'10003977'),
(666, N'Roofing Membranes', N'10002687'),
(667, N'Roofing Panels/Slabs', N'10002686'),
(668, N'Roofing Tiles/Slates/Shingles/Shakes', N'10002683'),
(669, N'Roofing Variety Packs', N'10002693'),
(670, N'Caulking', N'10003208'),
(672, N'Glue/Adhesive', N'10003207'),
(753, N'Cleaners Other', N'10000746'),
(699, N'Window Balances', N'10002557');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (701, N'Window Locks/Bolts', N'10002548'),
(729, N'Camping Water Purification Treatments', N'10005198'),
(730, N'Camping Beds/Sleeping Mats', N'10002079'),
(731, N'Camping Furniture/Furnishings Other', N'10002085'),
(732, N'Camping Seating', N'10002081'),
(733, N'Camping Storage', N'10002083'),
(734, N'Camping Tables', N'10002084'),
(735, N'Sleeping Bags', N'10002080'),
(736, N'Camping Heating/Lighting Equipment Other', N'10002077'),
(737, N'Camping Lanterns', N'10002076'),
(738, N'Camping Water Heaters', N'10004099'),
(739, N'Tent Heaters', N'10002075'),
(740, N'Camping Variety Packs', N'10002101'),
(741, N'Camping Showers', N'10002097'),
(742, N'Camping Toilets (Non Powered)', N'10002096'),
(743, N'Camping Toilets (Powered)', N'10004100'),
(744, N'Camping Washing/Sanitary Equipment – Replacement Parts/Accessories', N'10002098'),
(745, N'Camping Washing/Sanitary Equipment Other', N'10002099'),
(746, N'Tent Accessories', N'10002072'),
(747, N'Tent Treatments/Repair Kits', N'10002071'),
(748, N'Tents', N'10002069'),
(749, N'Tents/Weather Structures Other', N'10002073'),
(750, N'Weather Structures/Tent Extensions', N'10002070'),
(751, N'Baby Hygiene Products', N'10000505'),
(728, N'Camping Water Equipment', N'10002088'),
(700, N'Window Frames', N'10002543'),
(727, N'Camping Tableware', N'10003773'),
(725, N'Camping Cool Boxes/Bags (Non Powered)', N'10002091'),
(702, N'Window Parts/Accessories Other', N'10005292'),
(703, N'Window Screens', N'10002550'),
(704, N'Window Shutters', N'10003968'),
(705, N'Window Wells', N'10002554'),
(706, N'Windows – Replacement Sash – Wood', N'10005294'),
(707, N'Windowsill', N'10006792'),
(708, N'Skylights – Clad Wood', N'10005289'),
(709, N'Skylights – Non Wood', N'10002544'),
(710, N'Skylights – Tubular', N'10005288'),
(711, N'Windows – Bay/Bow – Clad Wood', N'10005297'),
(712, N'Windows – Bay/Bow – Non Wood', N'10005296'),
(713, N'Windows – Bay/Bow – Wood', N'10005295'),
(714, N'Windows – Combination Units – Clad Wood', N'10005287'),
(715, N'Windows – Combination Units – Non Wood', N'10005286');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (716, N'Windows – Combination Units – Wood', N'10002542'),
(717, N'Windows – Other', N'10005290'),
(718, N'Windows – Single Units – Clad Wood', N'10005284'),
(719, N'Windows – Single Units – Non Wood', N'10005285'),
(720, N'Windows – Single Units – Wood', N'10003946'),
(721, N'Windows – Storm', N'10002553'),
(722, N'Camping Cooking/Drinking/Eating Equipment – Replacement Parts/Accessories', N'10002093'),
(723, N'Camping Cooking/Drinking/Eating Equipment Other', N'10002094'),
(724, N'Camping Cookware', N'10002092'),
(726, N'Camping Stoves/Grills/Ovens', N'10002087'),
(860, N'Fax Machines', N'10001186'),
(431, N'Hair Care Products Variety Packs', N'10000677'),
(429, N'Hair – Styling (Powered)', N'10000678'),
(137, N'Audio (Non-Music) – Digital', N'10006240'),
(138, N'Audio Cassettes – Pre-recorded', N'10001464'),
(139, N'CD/MD – Pre-recorded', N'10001459'),
(140, N'Dual Discs – Pre-recorded', N'10003718'),
(141, N'DVD – Pre-recorded', N'10001460'),
(142, N'Graphics – Digital', N'10006245'),
(143, N'Music – Digital', N'10006239'),
(144, N'Pre-recorded Media Variety Packs', N'10001465'),
(145, N'Television Shows – Digital', N'10006244'),
(146, N'Video Cassettes – Pre-recorded', N'10001463'),
(136, N'Video Recording/Playback – Replacement Parts/Accessories', N'10001414'),
(147, N'Vinyl – Pre-recorded', N'10001462'),
(149, N'CD/MD – Recordable', N'10001450'),
(150, N'DVD – Recordable', N'10001451'),
(151, N'Floppy Discs', N'10001456'),
(152, N'Memory Cards', N'10001452'),
(153, N'Recordable Media Other', N'10001458'),
(154, N'USB Flash Drives/Thumb Drives', N'10006398'),
(155, N'Video Cassettes – Recordable', N'10001455'),
(156, N'Audio Visual/Photography Variety Packs', N'10003777'),
(157, N'Car Audio – Replacement Parts/Accessories', N'10001533'),
(158, N'Car Audio Aerials', N'10001531'),
(148, N'Audio Cassettes – Recordable', N'10001449'),
(135, N'Video Hard Disc Recorders', N'10001410'),
(134, N'Video Cassette Players/Recorders', N'10001412'),
(133, N'Memory Card Recorders', N'10005748'),
(110, N'Portable FM (Frequency Modulation) Transmitters', N'10005765'),
(111, N'Portable MD Players', N'10001417'),
(112, N'Portable MP3 Players', N'10001418');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (113, N'Portable PA (Public Address) Music Systems', N'10005807'),
(114, N'Portable Radio-recorders', N'10001423'),
(115, N'Portable Radios', N'10001422'),
(116, N'Portable Speakers', N'10005710'),
(117, N'Television Combinations', N'10001401'),
(118, N'Televisions', N'10001400'),
(119, N'Televisions – Hand-held', N'10001402'),
(120, N'Televisions – Replacement Parts/Accessories', N'10001404'),
(121, N'Televisions Variety Packs', N'10001403'),
(122, N'Aerials', N'10001411'),
(123, N'Audio/Visual Receivers', N'10005841'),
(124, N'Low-noise Block (LNB) Converters', N'10005736'),
(125, N'Satellite Reception Accessories', N'10005760'),
(126, N'Satellite/Terrestrial Antenna Systems', N'10005829'),
(127, N'Set-top Boxes', N'10001409'),
(128, N'Video Receiving/Installation Accessories', N'10005738'),
(129, N'Video Receiving/Installation Variety Packs', N'10005739'),
(130, N'Camcorders', N'10001406'),
(131, N'Combination Players/Recorders', N'10001408'),
(132, N'DVD Players/Recorders', N'10001407'),
(159, N'Car Audio Amplifiers', N'10001530'),
(160, N'Car Audio Cassette Players/Changers', N'10005205'),
(161, N'Car Audio CD Players/Changers', N'10001527'),
(162, N'Car Audio Head Units', N'10001525'),
(190, N'Photograph Albums/Cubes', N'10001495'),
(191, N'Photographic Camera Filters', N'10005755'),
(192, N'Photographic Film', N'10001490'),
(193, N'Photographic Slide Projectors', N'10001492'),
(194, N'Photographic Slide Storage', N'10005752'),
(195, N'Photographic Slides', N'10001493'),
(196, N'Photographic Slides – Replacement Parts/Accessories', N'10005751'),
(197, N'Photographic Studio Flash Gun', N'10005753'),
(198, N'Photography – Replacement Parts/Accessories', N'10001494'),
(199, N'Photography Other', N'10001498'),
(200, N'Photograph Developing Chemicals', N'10001507'),
(201, N'Photograph Enlargers', N'10001508'),
(202, N'Photographic Paper', N'10001510'),
(203, N'Photography Dark Room Safelights', N'10001512'),
(204, N'Photography Dark Room Tanks/Trays/Reels', N'10001513'),
(205, N'Photography Drying Equipment', N'10001511'),
(206, N'Photography Printing/Dark Room Equipment – Replacement Parts/Accessories', N'10001515'),
(207, N'Photography Printing/Dark Room Equipment Other', N'10001516');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (208, N'Photography/Optics Variety Packs', N'10003686'),
(209, N'Antifreeze/Coolants (Automotive)', N'10005234'),
(210, N'Anti-theft Products Other', N'10003009'),
(211, N'Anti-theft Products Replacement Parts/Accessories', N'10005129'),
(212, N'Anti-theft Products Variety Packs', N'10003010'),
(189, N'Photograph Albums – Replacement Parts/Accessories', N'10005207'),
(109, N'Portable DVD Players', N'10001420'),
(188, N'Mobile Photo Storage', N'10005842'),
(186, N'Digital Cameras', N'10001487'),
(163, N'Car Audio MD Players/Changers', N'10001528'),
(164, N'Car Audio Other', N'10001534'),
(165, N'Car Audio Speakers', N'10001529'),
(166, N'Car Audio Subwoofers', N'10005828'),
(167, N'Car Audio Tuners/Receivers', N'10001526'),
(168, N'Car Audio Variety Packs', N'10001532'),
(169, N'Car DVD Players', N'10001519'),
(170, N'Car GPS Antennae', N'10005749'),
(171, N'Car Navigation Equipment', N'10001517'),
(172, N'Car Radar Detectors', N'10005728'),
(173, N'Car Video Cassette Players', N'10001520'),
(174, N'Car Video Monitors', N'10001518'),
(175, N'Car Video Receiving Equipment', N'10001521'),
(176, N'Car Video/Navigation – Replacement Parts/Accessories', N'10001523'),
(177, N'Car Video/Navigation Other', N'10001524'),
(178, N'In-car Electronics Variety Packs', N'10003685'),
(179, N'Binoculars', N'10001499'),
(180, N'Magnifying Glasses', N'10003776'),
(181, N'Monoculars/Telescopes', N'10001501'),
(182, N'Optics Other', N'10001506'),
(183, N'Analogue Cameras', N'10001486'),
(184, N'Camera Flash Accessories', N'10005750'),
(185, N'Camera Flashes', N'10001489'),
(187, N'Digital Photo Frames', N'10005700'),
(108, N'Portable Digital Video Players', N'10001421'),
(107, N'Portable CD Players', N'10001416'),
(106, N'Portable Audio/Video Variety Packs', N'10001426'),
(29, N'Jewellery Craft Materials', N'10001717'),
(30, N'Jewellery Craft Supplies Other', N'10001720'),
(31, N'Foam Craft Materials', N'10005713'),
(32, N'Lace/Ribbons/Cords/Braids', N'10001700'),
(33, N'Needlework Accessories', N'10001714'),
(34, N'Needlework Fabrics/Textiles', N'10001699');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (35, N'Needlework Fasteners', N'10001710'),
(36, N'Needlework Hand/Machine Tools', N'10001702'),
(37, N'Needlework Marking Equipment', N'10001705'),
(38, N'Needlework Storage', N'10001712'),
(39, N'Needlework Templates', N'10001713'),
(40, N'Needlework Threads', N'10001701'),
(41, N'Needlework/Toy Making Craft Supplies Other', N'10001716'),
(42, N'Sewing/Knitting Machinery (Non Powered)', N'10001706'),
(43, N'Sewing/Knitting Machinery (Powered)', N'10001707'),
(44, N'Toy Making Accessories', N'10001711'),
(45, N'Paper Craft Tools (Non Powered)', N'10001726'),
(46, N'Paper Craft/Card Making Supplies Other', N'10001730'),
(47, N'Paper/Card Making Craft Accessories', N'10001727'),
(48, N'Printing Craft Supplies Other', N'10001753'),
(49, N'Printing Craft Tools', N'10001748'),
(50, N'Printing Press (Non Powered)', N'10001750'),
(51, N'Kilns (Powered)', N'10001694'),
(28, N'Jewellery Craft Accessories', N'10001718'),
(52, N'Pottery Wheels (Non Powered)', N'10001696'),
(27, N'Glasswork/Enamelling/Marquetry Craft Supplies Other', N'10001735'),
(25, N'Glasswork Craft Tools (Powered)', N'10001732'),
(2, N'Airbrushing Equipment – Replacement Parts/Accessories', N'10001688'),
(3, N'Airbrushing Supplies Other', N'10001690'),
(4, N'Artists Accessories', N'10001682'),
(5, N'Artists Brushes/Applicators', N'10001674'),
(6, N'Artists Canvas/Pre-primed Boards', N'10001679'),
(7, N'Artists Drawing Boards', N'10005372'),
(8, N'Artists Easels', N'10001681'),
(9, N'Artists Painting Surface Agents', N'10001678'),
(10, N'Artists Painting/Drawing Supplies Other', N'10001685'),
(11, N'Artists Paints/Dyes', N'10001676'),
(12, N'Artists Palettes', N'10001680'),
(13, N'Artists Pastels/Charcoal/Crayons', N'10001677'),
(14, N'Sand Art Supplies', N'10001683'),
(15, N'Arts/Crafts Variety Packs', N'10001760'),
(16, N'Basketry Craft Accessories', N'10001723'),
(17, N'Basketry Craft Materials', N'10001721'),
(18, N'Basketry Craft Supplies Other', N'10001725'),
(19, N'Basketry Craft Tools (Non Powered)', N'10001722'),
(20, N'Candle/Soap Craft Materials', N'10001736'),
(21, N'Candle/Soap Craft Moulds', N'10001737'),
(22, N'Candle/Soap Craft Supplies Variety Packs', N'10001740');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (23, N'Candle/Soap Craft Tools (Non Powered)', N'10001738'),
(24, N'Candle/Soap Craft Tools (Powered)', N'10001739'),
(26, N'Glasswork/Enamelling/Marquetry Craft Materials', N'10001731'),
(213, N'Car Alarms/Anti-jacking Alarms', N'10003004'),
(53, N'Pottery Wheels (Powered)', N'10001695'),
(55, N'Sculptors Tools (Powered)', N'10001693'),
(83, N'Wireless Television Links', N'10001469'),
(84, N'Audio Visual Equipment Variety Packs', N'10001485'),
(85, N'Home Audio Amplifiers/Preamplifiers', N'10001429'),
(86, N'Home Audio Cassette Decks', N'10001432'),
(87, N'Home Audio CD Decks', N'10001433'),
(88, N'Home Audio Effects Equipment', N'10001443'),
(89, N'Home Audio Equipment – Replacement Parts/Accessories', N'10001447'),
(90, N'Home Audio Equipment Other', N'10001448'),
(91, N'Home Audio Jukeboxes', N'10001440'),
(92, N'Home Audio Karaoke Systems', N'10001441'),
(93, N'Home Audio MD Decks', N'10001434'),
(94, N'Home Audio Receivers/Tuners/Radios', N'10001437'),
(95, N'Home Audio Speaker Systems', N'10001436'),
(96, N'Home Audio Speakers – Individual', N'10001435'),
(97, N'Home Audio/Visual Mixers', N'10001442'),
(98, N'Home Stereo Systems', N'10001430'),
(99, N'Home Theatre Systems', N'10001431'),
(100, N'Turntables – CD', N'10001444'),
(101, N'Turntables – Vinyl', N'10001439'),
(102, N'Clock Radios', N'10001424'),
(103, N'Dictation Machines', N'10001425'),
(104, N'Portable Audio Cassette Players', N'10001419'),
(105, N'Portable Audio/Video – Replacement Parts/Accessories', N'10001427'),
(82, N'Vibration Absorbers/Dampers', N'10005746'),
(54, N'Sculptors Tools (Non Powered)', N'10001692'),
(81, N'Universal Remote Controls', N'10001470'),
(79, N'Switch-boxes', N'10001472'),
(56, N'Sculptors/Pottery Craft Materials', N'10001691'),
(57, N'Sculptors/Pottery Craft Supplies Other', N'10001698'),
(58, N'Spinning/Weaving Craft – Replacement Parts/Accessories', N'10001757'),
(59, N'Spinning/Weaving Craft Supplies Other', N'10001758'),
(60, N'Spinning/Weaving Fibres/Yarns', N'10001756'),
(61, N'Spinning/Weaving Machines (Non Powered)', N'10001755'),
(62, N'Spinning/Weaving Machines (Powered)', N'10001754'),
(63, N'Wood Burning/Engraving Craft – Replacement Parts/Accessories', N'10001744'),
(64, N'Wood Burning/Engraving Craft Tools (Non Powered)', N'10001743');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (65, N'Wood Burning/Engraving Craft Tools (Powered)', N'10001742'),
(66, N'Analogue/Digital Converters', N'10005726'),
(67, N'Audio Headsets', N'10001467'),
(68, N'Audio Visual Accessories – Replacement Parts', N'10001483'),
(69, N'Audio Visual Accessories Variety Packs', N'10001482'),
(70, N'Audio Visual Bags/Boxes/Cases/Wallets', N'10001478'),
(71, N'Audio Visual Cleaning Products', N'10001480'),
(72, N'Audio Visual Labelling Systems', N'10005744'),
(73, N'Audio Visual Stands/Brackets', N'10001477'),
(74, N'Converter Cassettes', N'10001475'),
(75, N'Megaphones', N'10005204'),
(76, N'Microphones', N'10001476'),
(77, N'MP3 Docking Stations', N'10005747'),
(78, N'Sound-active Effect Lighting', N'10005809'),
(80, N'Television Internet Packs', N'10001479'),
(214, N'Immobilisers (Automotive)', N'10005241'),
(215, N'Locking Devices', N'10003755'),
(216, N'Tracking Devices', N'10003008'),
(352, N'Towing/Hitch Variety Packs', N'10002977'),
(353, N'Brake Controls', N'10002979'),
(354, N'Power Modules', N'10002980'),
(355, N'Towing/Hitch – Electrical Other', N'10002985'),
(356, N'Wiring Adapters/Converters', N'10002981'),
(357, N'Couplers – Trailer (Automotive)', N'10002988'),
(358, N'Trailer Brakes', N'10002989'),
(359, N'Trailer Jacks/Stands', N'10002987'),
(360, N'Trailer/Trailer Accessories Other', N'10002996'),
(361, N'Trailers', N'10002993'),
(362, N'Transmission Fluid', N'10002799'),
(363, N'Transmission Fluid Variety Packs', N'10002801'),
(364, N'Tyres', N'10002924'),
(365, N'Wheels', N'10002926'),
(366, N'Beauty/Trim Rings', N'10002935'),
(367, N'Disc Brake Simulators', N'10002934'),
(368, N'Jumper Cables', N'10006838'),
(369, N'Tyre Holder', N'10006839'),
(370, N'Tyre Inflators – Chemical (Automotive)', N'10002932'),
(371, N'Tyre Pumps (Automotive)', N'10002928'),
(372, N'Wheel Hardware', N'10002931'),
(373, N'Wheel Rim', N'10006377'),
(374, N'Winch Parts/Components', N'10002999'),
(351, N'Towing Mirrors (Automotive)', N'10002970');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (375, N'Winch/Winch Accessories Variety Packs', N'10003001'),
(350, N'Towing Components – Heavy Duty', N'10002974'),
(348, N'Safety Chains/Cables – Towing (Automotive)', N'10002971'),
(325, N'Air Conditioning Refrigerants', N'10005761'),
(326, N'Auto Repair Crawlers/Creepers', N'10005720'),
(327, N'Glass Repair/Kits', N'10002824'),
(328, N'Muffler/Exhaust Repair', N'10002817'),
(329, N'Rear-view Mirror Repair/Kits', N'10002822'),
(330, N'Window Defogger Repair/Kits', N'10002823'),
(331, N'Carburettor/Choke Sprays', N'10002779'),
(332, N'Carburettor/Parts Dip Cleaner', N'10002780'),
(333, N'Electric Parts Cleaner (Automotive)', N'10003775'),
(334, N'Engine Degreasers/Pollution Control', N'10002781'),
(335, N'Automotive Fire Extinguishers', N'10006904'),
(336, N'Emergency Fuel Aids', N'10002826'),
(337, N'Mirrors (Automotive)', N'10003774'),
(338, N'Protective Hose Bridges (Automotive)', N'10005821'),
(339, N'Safety Replacement Parts/Accessories (Automotive)', N'10003760'),
(340, N'Warning Flags/Flag Staffs (Automotive)', N'10005820'),
(341, N'Fuel Injectors', N'10006379'),
(342, N'Glow Plugs', N'10006380'),
(343, N'Spark Plugs Other', N'10003018'),
(344, N'Adaptors – Hitch (Automotive)', N'10002962'),
(345, N'Hitch Covers (Automotive)', N'10002968'),
(346, N'Hitch Steps (Automotive)', N'10002969'),
(347, N'Pins/Clips – Hitch (Automotive)', N'10002963'),
(349, N'Tow Hooks (Automotive)', N'10002965'),
(324, N'Spot Lights (Automotive)', N'10003759'),
(376, N'Washer Fluid (Automotive)', N'10003764'),
(378, N'Wiper Blades', N'10003011'),
(406, N'Skin Lightening', N'10000486'),
(407, N'Tattoos/Stencils/Stick-on Jewellery – Temporary', N'10000763'),
(408, N'Cosmetics/Fragrances Variety Packs', N'10000672'),
(409, N'Fragrances', N'10000365'),
(410, N'Cosmetics – Nails', N'10000360'),
(411, N'Nail Cosmetic/Care Products – Replacement Parts', N'10000768'),
(412, N'Nail Cosmetic/Care Products Variety Packs', N'10000671'),
(413, N'Nails – Accessories (Non Powered)', N'10000385'),
(414, N'Nails – Accessories (Powered)', N'10000767'),
(415, N'Nails – Aids (Non Powered)', N'10000358'),
(416, N'Nails – Aids (Powered)', N'10000780'),
(417, N'Nails – Cleansers/Cosmetic Removers', N'10000333');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (418, N'Nails – False', N'10000359'),
(419, N'Nails – Treatments', N'10000361'),
(420, N'Hair – Accessories', N'10000379'),
(421, N'Hair – Aids (Non Powered)', N'10000564'),
(422, N'Hair – Aids (Powered)', N'10000828'),
(423, N'Hair – Colour', N'10000345'),
(424, N'Hair – Conditioner/Treatment', N'10000346'),
(425, N'Hair – False', N'10000343'),
(426, N'Hair – Perming', N'10000348'),
(427, N'Hair – Shampoo', N'10000368'),
(428, N'Hair – Styling (Non Powered)', N'10000381'),
(405, N'Display Test (Cosmetics)', N'10006201'),
(377, N'Wiper Arms (Automotive)', N'10003142'),
(404, N'Cosmetics – Lips', N'10000534'),
(402, N'Cosmetics – Complexion', N'10000532'),
(379, N'Wiper Components Other', N'10003150'),
(380, N'Wiper Cowls', N'10003839'),
(381, N'Wiper Motors (Cores)', N'10003145'),
(382, N'Wiper Pumps', N'10003147'),
(383, N'Wipers/Wiper Parts Other', N'10003013'),
(384, N'Cars/Vans/Sport Utility Vehicles/Light Trucks', N'10006374'),
(385, N'All Terrain Vehicles (ATVs)', N'10006772'),
(386, N'Motorcycles', N'10006373'),
(387, N'Utility Task Vehicles (UTVs)/ Recreational Off-Road Vehicles (ROVs)', N'10006773'),
(388, N'Beauty/Personal Care/Hygiene Variety Packs', N'10000666'),
(389, N'Bath Massage/Toning', N'10000807'),
(390, N'Body Massage/Toning – Replacement Parts', N'10000758'),
(391, N'Body Massage/Toning Variety Packs', N'10000668'),
(392, N'Body Toning/Firming Products (Powered)', N'10000567'),
(393, N'Personal Warming/Massaging (Non Powered)', N'10000566'),
(394, N'Personal Warming/Massaging (Powered)', N'10000759'),
(395, N'Aromatherapy Cushions', N'10000772'),
(396, N'Aromatherapy Variety Packs', N'10000774'),
(397, N'Essential Oils', N'10000771'),
(398, N'Oil Diffusers (Powered)', N'10000770'),
(399, N'Cosmetic Aids/Accessories', N'10000377'),
(400, N'Cosmetic Paints/Shimmers/Glitters', N'10000761'),
(401, N'Cosmetic Products Variety Packs', N'10000669'),
(403, N'Cosmetics – Eyes', N'10000533'),
(430, N'Hair Care Products – Replacement Parts', N'10000833'),
(323, N'Replacement Lenses (Automotive)', N'10003045'),
(321, N'Lights/Bulbs Other (Automotive)', N'10003047');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (244, N'Cargo Management – Replacement Parts/Accessories', N'10005130'),
(245, N'Cargo Management Other (Automotive)', N'10002750'),
(246, N'Cargo Securing Equipment (Automotive)', N'10002733'),
(247, N'Equipment Racks/Carriers (Automotive)', N'10002734'),
(248, N'Extenders/Bumper Packs (Automotive)', N'10002743'),
(249, N'Exterior Storage Carriers/Bags (Automotive)', N'10005128'),
(250, N'Interior Storage Boxes/Trays/Baskets (Automotive)', N'10002748'),
(251, N'Wheel Chocks (Automotive)', N'10005818'),
(252, N'Decorative Lighting Other (Automotive)', N'10003057'),
(253, N'Strobe Lighting (Automotive)', N'10003055'),
(254, N'Automotive Electrical – Replacement Parts/Accessories', N'10005131'),
(255, N'Automotive Instruments and Measurement Systems', N'10006846'),
(256, N'Automotive Switches', N'10005132'),
(257, N'Cigarette Lighters/Adaptors (Automotive)', N'10003081'),
(258, N'Electrical Other (Automotive)', N'10003084'),
(259, N'Flex Tube/Wire Loom (Automotive)', N'10003080'),
(260, N'Horns/Sirens (Automotive)', N'10003758'),
(261, N'Coverings/Protection Other (Automotive)', N'10002909'),
(262, N'Lens Covers (Automotive)', N'10002902'),
(263, N'License Plates – Decorative', N'10002904'),
(264, N'Spare Tyre Covers', N'10002905'),
(265, N'Tops/Skins – Replacement Parts/Accessories (Automotive)', N'10002908'),
(266, N'Vehicle Covers', N'10002900'),
(243, N'Other Parts for Brake Systems', N'10006388'),
(267, N'Brush/Grill Guards', N'10002888'),
(242, N'Brake Pads/Lining', N'10006384'),
(240, N'Brake Disc Clip', N'10006386'),
(217, N'Appearance Chemicals Other (Automotive)', N'10002776'),
(218, N'Automotive Paint', N'10006378'),
(219, N'Car Body Care – Washes/Waxes/Protectors/Removers', N'10002767'),
(220, N'Car Interior Cleaning Kit', N'10006375'),
(221, N'Car Tyre Care – Cleaners/Foams/Shines', N'10002764'),
(222, N'Car Wheel Care – Cleaners/Shines', N'10002773'),
(223, N'Car Windscreen Preparation (Automotive)', N'10002757'),
(224, N'Air Fresheners – Non Powered (Automotive)', N'10003753'),
(225, N'Air Fresheners – Powered (Automotive)', N'10003752'),
(226, N'Appearance/Fragrance Accessories Other', N'10002949'),
(227, N'Automotive Appearance/Fragrance – Accessories/Replacement Parts', N'10005127'),
(228, N'Automotive Applicators/Brushes', N'10005249'),
(229, N'Buffers/Polishing Machines (Automotive)', N'10002944'),
(230, N'Ice Scrapers (Automotive)', N'10003757'),
(231, N'Washing/Cleaning Systems – Powered (Automotive)', N'10002940');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (232, N'Batteries (Automotive)', N'10005232'),
(233, N'Battery Accessories (Automotive)', N'10005233'),
(234, N'Battery Booster', N'10006383'),
(235, N'Automotive Body Repair Variety Packs', N'10003834'),
(236, N'Body Repair Other (Automotive)', N'10003761'),
(237, N'Reducers/Retarders (Automotive)', N'10002723'),
(238, N'Scratch Fill/Plastic Repair Preparations (Automotive)', N'10002720'),
(239, N'Brake Disc', N'10006385'),
(241, N'Brake Drum/Brake Drum Parts', N'10006389'),
(322, N'Reflectors (Automotive)', N'10003046'),
(268, N'Decorative/Custom Grills', N'10002890'),
(270, N'Extruded/Cast Steps (Automotive)', N'10002886'),
(298, N'Headliners/Kits (Automotive)', N'10002881'),
(299, N'Interior Accessories – Decorative Variety Packs (Automotive)', N'10002882'),
(300, N'Pedal Covers/Sets (Automotive)', N'10002877'),
(301, N'Shifter Knobs/Handles (Automotive)', N'10002875'),
(302, N'Dash Trim Kits', N'10002870'),
(303, N'Door Steps/Kick Plates (Automotive)', N'10002866'),
(304, N'Floor Mats (Automotive)', N'10002867'),
(305, N'Interior Cargo Liner/Trays (Automotive)', N'10002868'),
(306, N'Replacement Carpet (Automotive)', N'10002865'),
(307, N'Interior Storage Other (Automotive)', N'10002846'),
(308, N'Tax Disc Holders (Automotive)', N'10005122'),
(309, N'Baby Car/Booster Seats', N'10000792'),
(310, N'Head/Neck Cushions (Automotive)', N'10002842'),
(311, N'Seat Belts/Extenders', N'10002840'),
(312, N'Seat Cushions (Automotive)', N'10002839'),
(313, N'Seats (Automotive)', N'10002837'),
(314, N'Steering Wheel Hardware/Accessories', N'10002864'),
(315, N'Window Tints', N'10002860'),
(316, N'Windshield Shades', N'10002859'),
(317, N'Assemblies – Taillight', N'10003050'),
(318, N'Back Up Lights (Automotive)', N'10003037'),
(319, N'Driving Lights', N'10003038'),
(320, N'Fog Lights (Automotive)', N'10003036'),
(297, N'Decorative Accessory Knobs/Buttons', N'10002878'),
(269, N'Push/A Bars (Automotive)', N'10002889'),
(296, N'Thermometers (Automotive)', N'10002855'),
(294, N'Key Holders (Automotive)', N'10002852'),
(271, N'Running Boards (Automotive)', N'10002884'),
(272, N'Cab Fairings', N'10002898'),
(273, N'Rear Window Deflector/Roof Visors (Automotive)', N'10002896');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (274, N'Sunroof Deflectors', N'10002897'),
(275, N'Emblems/Graphics – Decorative (Automotive)', N'10002920'),
(276, N'Exterior Appearance Accessories Variety Packs', N'10002923'),
(277, N'Light/Lens Mouldings (Automotive)', N'10002919'),
(278, N'Scoops/Vents (Automotive)', N'10002911'),
(279, N'Sunroofs/Moonroofs/T-tops (Automotive)', N'10002910'),
(280, N'Air/Dust Filter Cleaner', N'10006328'),
(281, N'Filter Accessories (Automotive)', N'10003026'),
(282, N'Filters – Air (Automotive)', N'10003022'),
(283, N'Filters – Fluid (Automotive)', N'10003762'),
(284, N'Filters Other (Automotive)', N'10003029'),
(285, N'Performance Filter Kits/Accessories (Automotive)', N'10003028'),
(286, N'Fluid Change Items Other (Automotive)', N'10003114'),
(287, N'Oil Mats (Automotive)', N'10003113'),
(288, N'Filter Wrenches (Automotive)', N'10003092'),
(289, N'Fluid Management/Accessories Other (Automotive)', N'10003105'),
(290, N'Fluid Mixers (Automotive)', N'10003099'),
(291, N'Clocks (Automotive)', N'10002848'),
(292, N'Compasses (Automotive)', N'10002850'),
(293, N'Fans (Automotive)', N'10002857'),
(295, N'Refrigeration/Warmer Units (Automotive)', N'10002858'),
(861, N'Fixed Communication Devices Accessories', N'10005681'),
(546, N'Curtain Rod/Track Accessories', N'10003767'),
(863, N'Fixed Communication Pre-pay Vouchers/Calling Cards', N'10001188'),
(1430, N'Quark Products (Frozen)', N'10006756'),
(1431, N'Quark Products (Perishable)', N'10006757'),
(1432, N'Quark Products (Shelf Stable)', N'10006758'),
(1433, N'Yogurt/Yogurt Substitutes (Frozen)', N'10000277'),
(1434, N'Yogurt/Yogurt Substitutes (Perishable)', N'10000278'),
(1435, N'Yogurt/Yogurt Substitutes (Shelf Stable)', N'10000279'),
(1436, N'Nuts/Seeds – Unprepared/Unprocessed (Perishable)', N'10000007'),
(1437, N'Nuts/Seeds – Unprepared/Unprocessed (Shelf Stable)', N'10000008'),
(1438, N'Fats Edible – Animal (Perishable)', N'10000041'),
(1439, N'Fats Edible – Animal (Shelf Stable)', N'10000574'),
(1429, N'Milk/Milk Substitutes (Shelf Stable)', N'10000026'),
(1440, N'Fats Edible – Vegetable/Plant (Perishable)', N'10000585'),
(1442, N'Fats Edible Variety Packs', N'10000608'),
(1443, N'Oils Edible – Vegetable or Plant (Shelf Stable)', N'10000040'),
(1444, N'Oils/Fats Edible Variety Packs', N'10000609'),
(1445, N'Baby/Infant – Formula (Shelf Stable)', N'10000575'),
(1446, N'Baby/Infant – Specialised Beverages (Shelf Stable)', N'10000105'),
(1447, N'Baby/Infant – Specialised Foods (Frozen)', N'10006273');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1448, N'Baby/Infant – Specialised Foods (Shelf Stable)', N'10000104'),
(1449, N'Dairy Based Products / Meals – Not Ready to Eat/Drink (Frozen)', N'10005827'),
(1450, N'Dairy Based Products / Meals – Not Ready to Eat/Drink (Perishable)', N'10005826'),
(1451, N'Dairy/Egg Based Products / Meals – Ready to Eat (Perishable)', N'10005227'),
(1441, N'Fats Edible – Vegetable/Plant (Shelf Stable)', N'10000042'),
(1428, N'Milk/Milk Substitutes (Perishable)', N'10000025'),
(1427, N'Milk/Milk Substitutes (Frozen)', N'10000027'),
(1426, N'Milk/Butter/Cream/Yogurts/Cheese/Eggs/Substitutes Variety Packs', N'10000607'),
(1403, N'Chicken Sausages – Prepared/Processed', N'10005834'),
(1404, N'Lamb/Mutton Sausages – Prepared/Processed', N'10005835'),
(1405, N'Mixed Species Sausages – Prepared/Processed', N'10005836'),
(1406, N'Pork Sausages – Prepared/Processed', N'10005840'),
(1407, N'Turkey Sausages – Prepared/Processed', N'10005837'),
(1408, N'Veal Sausages – Prepared/Processed', N'10005838'),
(1409, N'Butter/Butter Substitutes (Frozen)', N'10000167'),
(1410, N'Butter/Butter Substitutes (Perishable)', N'10000168'),
(1411, N'Butter/Butter Substitutes (Shelf Stable)', N'10000169'),
(1412, N'Cheese/Cheese Substitutes (Frozen)', N'10000030'),
(1413, N'Cheese/Cheese Substitutes (Perishable)', N'10000028'),
(1414, N'Cheese/Cheese Substitutes (Shelf Stable)', N'10000029'),
(1415, N'Cream/Cream Substitutes (Frozen)', N'10000188'),
(1416, N'Cream/Cream Substitutes (Perishable)', N'10000189'),
(1417, N'Cream/Cream Substitutes (Shelf Stable)', N'10000190'),
(1418, N'Dairy By-Products', N'10006728'),
(1419, N'Eggs Extracts', N'10006204'),
(1420, N'In-Shell Checked/Dirty Eggs', N'10006203'),
(1421, N'In-Shell Nest Run Eggs', N'10006202'),
(1422, N'Eggs Imitations', N'10006213'),
(1423, N'Eggs Products/Substitutes', N'10006212'),
(1424, N'In Shell Table Eggs', N'10006210'),
(1425, N'Individually Cooked Eggs', N'10006211'),
(1452, N'Dairy/Egg Based Products / Meals – Ready to Eat (Shelf Stable)', N'10005228'),
(1453, N'Dairy/Egg Based Products / Meals Variety Packs', N'10006229'),
(1454, N'Egg Based Products / Meals – Not Ready to Eat (Frozen)', N'10005224'),
(1455, N'Egg Based Products / Meals – Not Ready to Eat (Perishable)', N'10005225'),
(1483, N'Pasta/Noodles – Not Ready to Eat (Perishable)', N'10000317'),
(1484, N'Pasta/Noodles – Not Ready to Eat (Shelf Stable)', N'10000242'),
(1485, N'Pasta/Noodles – Ready to Eat (Perishable)', N'10000240'),
(1486, N'Pasta/Noodles – Ready to Eat (Shelf Stable)', N'10000241'),
(1487, N'Pasta/Noodles Variety Packs', N'10006219'),
(1488, N'Soup Additions (Frozen)', N'10006314'),
(1489, N'Soup Additions (Perishable)', N'10006315');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1490, N'Soup Additions (Shelf Stable)', N'10006316'),
(1491, N'Soups – Prepared (Frozen)', N'10000260'),
(1492, N'Soups – Prepared (Perishable)', N'10000261'),
(1493, N'Soups – Prepared (Shelf Stable)', N'10000262'),
(1494, N'Soups – Prepared Variety Packs', N'10006216'),
(1495, N'Ready-Made Combination Meals – Not Ready to Eat (Frozen)', N'10006748'),
(1496, N'Ready-Made Combination Meals – Not Ready to Eat (Perishable)', N'10006749'),
(1497, N'Ready-Made Combination Meals – Not Ready to Eat (Shelf Stable)', N'10006750'),
(1498, N'Ready-Made Combination Meals – Not Ready to Eat Variety Packs', N'10006754'),
(1499, N'Ready-Made Combination Meals – Ready to Eat (Perishable)', N'10006751'),
(1500, N'Ready-Made Combination Meals – Ready to Eat (Shelf Stable)', N'10006752'),
(1501, N'Ready-Made Combination Meals – Ready to Eat Variety Packs', N'10006753'),
(1502, N'Sandwiches/Filled Rolls/Wraps (Frozen)', N'10000254'),
(1503, N'Sandwiches/Filled Rolls/Wraps (Perishable)', N'10000255'),
(1504, N'Sandwiches/Filled Rolls/Wraps Variety Packs', N'10006217'),
(1505, N'Caramel/Toffee Apples', N'10005822'),
(1482, N'Pasta/Noodles – Not Ready to Eat (Frozen)', N'10000318'),
(1402, N'Beef Sausages – Prepared/Processed', N'10005833'),
(1481, N'Meat Substitutes Variety Packs', N'10006230'),
(1479, N'Meat Substitutes (Perishable)', N'10005824'),
(1456, N'Egg Based Products / Meals – Not Ready to Eat (Shelf Stable)', N'10005226'),
(1457, N'Dessert Sauces/Toppings/Fillings (Frozen)', N'10000193'),
(1458, N'Dessert Sauces/Toppings/Fillings (Perishable)', N'10000194'),
(1459, N'Dessert Sauces/Toppings/Fillings (Shelf Stable)', N'10000195'),
(1460, N'Desserts (Frozen)', N'10000196'),
(1461, N'Desserts (Perishable)', N'10000197'),
(1462, N'Desserts (Shelf Stable)', N'10000312'),
(1463, N'Desserts/Dessert Toppings Variety Packs', N'10000611'),
(1464, N'Ice Cream/Ice Novelties (Frozen)', N'10000215'),
(1465, N'Ice Cream/Ice Novelties (Shelf Stable)', N'10000216'),
(1466, N'Dough Based Products / Meals – Not Ready to Eat – Savoury (Frozen)', N'10000301'),
(1467, N'Dough Based Products / Meals – Not Ready to Eat – Savoury (Perishable)', N'10000300'),
(1468, N'Dough Based Products / Meals – Not Ready to Eat – Savoury (Shelf Stable)', N'10000302'),
(1469, N'Dough Based Products / Meals – Ready to Eat – Savoury (Perishable)', N'10000298'),
(1470, N'Dough Based Products / Meals – Ready to Eat – Savoury (Shelf Stable)', N'10000299'),
(1471, N'Dough Based Products / Meals Variety Packs', N'10006222'),
(1472, N'Grain Based Products / Meals – Not Ready to Eat – Savoury (Frozen)', N'10000296'),
(1473, N'Grain Based Products / Meals – Not Ready to Eat – Savoury (Perishable)', N'10000295'),
(1474, N'Grain Based Products / Meals – Not Ready to Eat – Savoury (Shelf Stable)', N'10000297'),
(1475, N'Grain Based Products / Meals – Ready to Eat – Savoury (Perishable)', N'10000293'),
(1476, N'Grain Based Products / Meals – Ready to Eat – Savoury (Shelf Stable)', N'10000294'),
(1477, N'Grain Based Products / Meals Variety Packs', N'10006228');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1478, N'Meat Substitutes  (Frozen)', N'10005823'),
(1480, N'Meat Substitutes (Shelf Stable)', N'10005825'),
(1401, N'Alternative Meat/Poultry/Other Animal Sausages – Prepared/Processed', N'10005832'),
(1400, N'Wild Boar – Unprepared/Unprocessed', N'10006280'),
(1399, N'Water Buffalo – Unprepared/Unprocessed', N'10006286'),
(1322, N'Purslane', N'10006092'),
(1323, N'Rocket', N'10006088'),
(1324, N'Sorrel', N'10006090'),
(1325, N'Watercress', N'10006048'),
(1326, N'Hin Choy', N'10006420'),
(1327, N'New-Zealand Spinach', N'10006427'),
(1328, N'Spinach', N'10006091'),
(1329, N'Water Spinach /Ong Choy', N'10006352'),
(1330, N'Celtuce', N'10006761'),
(1331, N'Alternative Meat/Poultry/Other Animals Species – Prepared/Processed', N'10005783'),
(1332, N'Antelope – Prepared/Processed', N'10006298'),
(1333, N'Beef – Prepared/Processed', N'10005767'),
(1334, N'Beefalo/Cattalo – Prepared/Processed', N'10006299'),
(1335, N'Bison/Buffalo – Prepared/Processed', N'10005768'),
(1336, N'Chicken – Prepared/Processed', N'10005769'),
(1337, N'Deer, other than Roe Deer – Prepared/Processed', N'10005770'),
(1338, N'Duck – Prepared/Processed', N'10005771'),
(1339, N'Elk/Wapiti – Prepared/Processed', N'10006300'),
(1340, N'Emu – Prepared/Processed', N'10006304'),
(1341, N'Frog – Prepared/Processed', N'10005772'),
(1342, N'Goat – Prepared/Processed', N'10005773'),
(1343, N'Goose – Prepared/Processed', N'10006305'),
(1344, N'Guinea Fowl – Prepared/Processed', N'10006306'),
(1321, N'Lambs Lettuce', N'10006086'),
(1345, N'Hare – Prepared/Processed', N'10006297'),
(1320, N'Dandelion Greens/Lion''s Tooth', N'10006089'),
(1318, N'Oakleaf Lettuce', N'10006426'),
(1295, N'Fruit/Nuts/Seeds Mixes – Prepared/Processed (Shelf Stable)', N'10000207'),
(1296, N'Fruits/Vegetables/Nuts/Seeds Variety Packs', N'10000605'),
(1297, N'Nuts/Seeds – Prepared/Processed (Perishable)', N'10000235'),
(1298, N'Nuts/Seeds – Prepared/Processed (Shelf Stable)', N'10000236'),
(1299, N'Vegetables – Prepared/Processed (Frozen)', N'10000270'),
(1300, N'Vegetables – Prepared/Processed (Perishable)', N'10000271'),
(1301, N'Vegetables – Prepared/Processed (Shelf Stable)', N'10000272'),
(1302, N'Common Chicory', N'10006422'),
(1303, N'Endive (Broad Leaf)', N'10006155'),
(1304, N'Endive (Curled)', N'10006097');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1305, N'Puntarelle', N'10006423'),
(1306, N'Radicchio (Redloof)', N'10006421'),
(1307, N'Radicchio Rosso', N'10006094'),
(1308, N'Sugarloaf', N'10006095'),
(1309, N'Witloof (Belgian Endive)', N'10006093'),
(1310, N'Batavia', N'10006419'),
(1311, N'Head Lettuce (Butterhead)', N'10006079'),
(1312, N'Iceberg Lettuce', N'10006267'),
(1313, N'Romaine (Cos) Lettuce', N'10006085'),
(1314, N'Leaf Vegetables – Unprepared/Unprocessed Variety Packs', N'10006428'),
(1315, N'Lollo Bionda', N'10006424'),
(1316, N'Lollo Rosso', N'10006425'),
(1317, N'Loose Leaf/Multileaf Lettuce Other', N'10006268'),
(1319, N'Baby Leaves', N'10006269'),
(1506, N'Chips/Crisps/Snack Mixes – Natural/Extruded (Shelf Stable)', N'10000177'),
(1346, N'Horse – Prepared/Processed', N'10005774'),
(1348, N'Land Snail – Prepared/Processed', N'10005776'),
(1376, N'Frog – Unprepared/Unprocessed', N'10005791'),
(1377, N'Goat – Unprepared/Unprocessed', N'10005792'),
(1378, N'Goose – Unprepared/Unprocessed', N'10006289'),
(1379, N'Guinea Fowl – Unprepared/Unprocessed', N'10006290'),
(1380, N'Hare – Unprepared/Unprocessed', N'10006281'),
(1381, N'Horse – Unprepared/Unprocessed', N'10005793'),
(1382, N'Lamb – Unprepared/Unprocessed', N'10006278'),
(1383, N'Land Snail – Unprepared/Unprocessed', N'10005795'),
(1384, N'Llama/Alpaca – Unprepared/Unprocessed', N'10005796'),
(1385, N'Mixed Species Meat – Unprepared/Unprocessed', N'10005797'),
(1386, N'Moose/Elk – Unprepared/Unprocessed', N'10006285'),
(1387, N'Mutton – Unprepared/Unprocessed', N'10006279'),
(1388, N'Ostrich – Unprepared/Unprocessed', N'10005798'),
(1389, N'Pheasant – Unprepared/Unprocessed', N'10005799'),
(1390, N'Pork – Unprepared/Unprocessed', N'10005800'),
(1391, N'Quail – Unprepared/Unprocessed', N'10006291'),
(1392, N'Rabbit – Unprepared/Unprocessed', N'10005801'),
(1393, N'Reindeer/Caribou – Unprepared/Unprocessed', N'10006287'),
(1394, N'Rhea – Unprepared/Unprocessed', N'10006292'),
(1395, N'Roe Deer – Unprepared/Unprocessed', N'10006394'),
(1396, N'Squab/Pigeon – Unprepared/Unprocessed', N'10006293'),
(1397, N'Turkey – Unprepared/Unprocessed', N'10005803'),
(1398, N'Veal – Unprepared/Unprocessed', N'10005804'),
(1375, N'Emu – Unprepared/Unprocessed', N'10006288'),
(1347, N'Lamb – Prepared/Processed', N'10006294');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1374, N'Elk/Wapiti – Unprepared/Unprocessed', N'10006284'),
(1372, N'Deer, other than Roe Deer – Unprepared/Unprocessed', N'10005789'),
(1349, N'Llama/Alpaca – Prepared/Processed', N'10005777'),
(1350, N'Mixed Species Meat/Poultry/Other Animal - Alternative Meat – Prepared/Processed', N'10005778'),
(1351, N'Moose/Elk – Prepared/Processed', N'10006301'),
(1352, N'Mutton – Prepared/Processed', N'10006295'),
(1353, N'Ostrich – Prepared/Processed', N'10005779'),
(1354, N'Pheasant – Prepared/Processed', N'10005780'),
(1355, N'Pork – Prepared/Processed', N'10005781'),
(1356, N'Quail – Prepared/Processed', N'10006307'),
(1357, N'Rabbit – Prepared/Processed', N'10005782'),
(1358, N'Reindeer/Caribou – Prepared/Processed', N'10006303'),
(1359, N'Rhea – Prepared/Processed', N'10006308'),
(1360, N'Roe Deer – Prepared/Processed', N'10006393'),
(1361, N'Squab/Pigeon – Prepared/Processed', N'10006309'),
(1362, N'Turkey – Prepared/Processed', N'10005784'),
(1363, N'Veal – Prepared/Processed', N'10005785'),
(1364, N'Water Buffalo – Prepared/Processed', N'10006302'),
(1365, N'Wild Boar – Prepared/Processed', N'10006296'),
(1366, N'Alternative Meat/Poultry/Other Animal Species – Unprepared/Unprocessed', N'10005802'),
(1367, N'Antelope – Unprepared/Unprocessed', N'10006282'),
(1368, N'Beef – Unprepared/Unprocessed', N'10005786'),
(1369, N'Beefalo/Cattalo – Unprepared/Unprocessed', N'10006283'),
(1370, N'Bison/Buffalo – Unprepared/Unprocessed', N'10005787'),
(1371, N'Chicken – Unprepared/Unprocessed', N'10005788'),
(1373, N'Duck – Unprepared/Unprocessed', N'10005790'),
(1294, N'Fruit/Nuts/Seeds Combination Variety Packs', N'10000604'),
(1507, N'Doodles/ Puffs', N'10006746'),
(1509, N'Salt Sticks / Mini Pretzels', N'10006747'),
(1645, N'Kurrat', N'10006007'),
(1646, N'Onions', N'10006006'),
(1647, N'Shallots', N'10006009'),
(1648, N'Spring (or Spanish) Onions', N'10006005'),
(1649, N'Chickpeas', N'10006271'),
(1650, N'Crooked Cucumber', N'10006450'),
(1651, N'Cucumbers', N'10006014'),
(1652, N'Gherkins', N'10006449'),
(1653, N'Bitter Melon', N'10006349'),
(1654, N'Courgettes', N'10006015'),
(1644, N'Garlic', N'10006003'),
(1655, N'Squash (Calabaza)', N'10006355'),
(1657, N'Squash (Opo)', N'10006357');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1658, N'Gourds', N'10006340'),
(1659, N'Pumpkins/Winter Squash', N'10006038'),
(1660, N'Edible Flowers', N'10006261'),
(1661, N'Ferns (Cinnamon)', N'10006361'),
(1662, N'Ferns (Royal)', N'10006362'),
(1663, N'Fiddlehead Ferns', N'10006824'),
(1664, N'Beech Mushrooms', N'10006263'),
(1665, N'Cep', N'10006035'),
(1666, N'Chanterelles', N'10006033'),
(1656, N'Squash (Choko)', N'10006356'),
(1643, N'Elephant Garlic', N'10006004'),
(1642, N'White Cabbages', N'10005999'),
(1641, N'Turnips', N'10006120'),
(1618, N'Bimi and Other Brassica Interbreeds', N'10006445'),
(1619, N'Black Mustard', N'10006341'),
(1620, N'Broccoli', N'10005988'),
(1621, N'Brussel Sprouts', N'10005996'),
(1622, N'Cauliflower', N'10005987'),
(1623, N'Chinese Cabbages', N'10006143'),
(1624, N'Choi Sum', N'10006446'),
(1625, N'Gai Choy (Mustard Greens)', N'10006339'),
(1626, N'Gai Lan', N'10006823'),
(1627, N'Greens (Texas Mustard)', N'10006342'),
(1628, N'Kale', N'10006144'),
(1629, N'Kohlrabi', N'10006146'),
(1630, N'May Turnips', N'10006116'),
(1631, N'Mizuna', N'10006444'),
(1632, N'Pak Choi', N'10006145'),
(1633, N'Pointed Cabbage', N'10006197'),
(1634, N'Red Cabbages', N'10005997'),
(1635, N'Romanesco', N'10006196'),
(1636, N'Savoy Cabbages', N'10006000'),
(1637, N'Swedish Turnips (Rutabagas)', N'10006118'),
(1638, N'Tatsoi', N'10006447'),
(1639, N'Teltow Turnips', N'10006119'),
(1640, N'Turnip Tops', N'10006117'),
(1667, N'Common Cultivated Mushroom (Agaricus)', N'10006157'),
(1668, N'Enokitake', N'10006264'),
(1669, N'Eryngii', N'10006265'),
(1670, N'Lingzhi Mushrooms', N'10006836'),
(1698, N'Laurel', N'10006058'),
(1699, N'Lemon Thyme', N'10006076');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1700, N'Lemon Verbena', N'10006078'),
(1701, N'Lemongrass', N'10006159'),
(1702, N'Lovage', N'10006057'),
(1703, N'Marjoram', N'10006059'),
(1704, N'Mugwort', N'10006044'),
(1705, N'Oregano', N'10006066'),
(1706, N'Peppermint', N'10006062'),
(1707, N'Pot Marjoram', N'10006060'),
(1708, N'Ramsons', N'10006040'),
(1709, N'Rosemary', N'10006072'),
(1710, N'Sage', N'10006353'),
(1711, N'Spearmint', N'10006064'),
(1712, N'Summer Savoury', N'10006045'),
(1713, N'Sweet Cicely', N'10006065'),
(1714, N'Tarragon', N'10006051'),
(1715, N'Winter Savoury', N'10006046'),
(1716, N'Armenian Cucumber', N'10006830'),
(1717, N'Conomon Melons', N'10006829'),
(1718, N'Melon (Horned)', N'10006350'),
(1719, N'Netted Muskmelons', N'10006828'),
(1720, N'Non-Netted Cantaloupe Melons', N'10006826'),
(1697, N'Hyssop', N'10006077'),
(1617, N'Yardlong Beans', N'10006158'),
(1696, N'Holy Basil', N'10006042'),
(1694, N'Garden Cress', N'10006055'),
(1671, N'Morels', N'10006032'),
(1672, N'Oyster Mushrooms', N'10006031'),
(1673, N'Shiitake Mushrooms', N'10006034'),
(1674, N'Truffles', N'10006036'),
(1675, N'Wild Mushrooms (Other)', N'10006266'),
(1676, N'American Basil', N'10006043'),
(1677, N'Anise', N'10006334'),
(1678, N'Apple Mint', N'10006063'),
(1679, N'Archangel', N'10006050'),
(1680, N'Balm', N'10006061'),
(1681, N'Basil', N'10006041'),
(1682, N'Borage', N'10006047'),
(1683, N'Burnet Saxifrage', N'10006071'),
(1684, N'Caraway', N'10006056'),
(1685, N'Celery Leaves', N'10006457'),
(1686, N'Chervil', N'10006053'),
(1687, N'Chives', N'10006074');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1688, N'Common Thyme', N'10006075'),
(1689, N'Coriander', N'10006054'),
(1690, N'Curled Parsley', N'10006198'),
(1691, N'Dill', N'10006049'),
(1692, N'Fennel  (Subspecies dulce)', N'10006052'),
(1693, N'Flat Parsley (Italian)', N'10006199'),
(1695, N'Herbs Variety Pack', N'10006456'),
(1616, N'Tamarindo', N'10006359'),
(1615, N'Runner Beans', N'10005979'),
(1614, N'Lima Beans', N'10005982'),
(1537, N'Aquatic Plants Unprepared/Unprocessed (Frozen)', N'10000138'),
(1538, N'Aquatic Plants Unprepared/Unprocessed (Perishable)', N'10000137'),
(1539, N'Aquatic Plants Unprepared/Unprocessed (Shelf Stable)', N'10000139'),
(1540, N'Fish – Prepared/Processed (Frozen)', N'10000017'),
(1541, N'Fish – Prepared/Processed (Perishable)', N'10000016'),
(1542, N'Fish – Prepared/Processed (Shelf Stable)', N'10000018'),
(1543, N'Fish – Unprepared/Unprocessed (Frozen)', N'10000281'),
(1544, N'Fish – Unprepared/Unprocessed (Perishable)', N'10000282'),
(1545, N'Fish – Unprepared/Unprocessed (Shelf Stable)', N'10000283'),
(1546, N'Seafood Variety Packs', N'10000614'),
(1547, N'Shellfish Prepared/Processed (Frozen)', N'10000256'),
(1548, N'Shellfish Prepared/Processed (Perishable)', N'10000257'),
(1549, N'Shellfish Prepared/Processed (Shelf Stable)', N'10000258'),
(1550, N'Shellfish – Unprepared/Unprocessed (Frozen)', N'10000020'),
(1551, N'Shellfish – Unprepared/Unprocessed (Perishable)', N'10000019'),
(1552, N'Shellfish – Unprepared/Unprocessed (Shelf Stable)', N'10000021'),
(1553, N'Extracts/Salt/Meat Tenderisers (Shelf Stable)', N'10000050'),
(1554, N'Extracts/Seasonings/Flavour Enhancers (Shelf Stable)', N'10006214'),
(1555, N'Herbs/Spices (Frozen)', N'10000212'),
(1556, N'Herbs/Spices (Perishable)', N'10000048'),
(1557, N'Herbs/Spices (Shelf Stable)', N'10000049'),
(1558, N'Herbs/Spices/Extracts Variety Packs', N'10000615'),
(1559, N'Stock/Bones (Frozen)', N'10000580'),
(1536, N'Aquatic Plants Prepared/Processed (Shelf Stable)', N'10000153'),
(1560, N'Stock/Bones (Perishable)', N'10000579'),
(1535, N'Aquatic Plants Prepared/Processed (Perishable)', N'10000152'),
(1533, N'Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Unprepared/Unprocessed (Shelf Stable)', N'10000631'),
(1510, N'Confectionery Based Spreads (Shelf Stable)', N'10000187'),
(1511, N'Honey (Shelf Stable)', N'10000213'),
(1512, N'Honey Substitutes', N'10006848'),
(1513, N'Jams/Marmalades (Shelf Stable)', N'10000217'),
(1514, N'Jams/Marmalades/Fruit Spreads (Perishable)', N'10006837');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1515, N'Sweet Spreads Variety Packs', N'10000621'),
(1516, N'Vegetable Based Products / Meals – Not Ready to Eat (Frozen)', N'10000291'),
(1517, N'Vegetable Based Products / Meals – Not Ready to Eat (Perishable)', N'10000290'),
(1518, N'Vegetable Based Products / Meals – Not Ready to Eat (Shelf Stable)', N'10000292'),
(1519, N'Vegetable Based Products / Meals – Ready to Eat (Perishable)', N'10000289'),
(1520, N'Vegetable Based Products / Meals – Ready to Eat (Shelf Stable)', N'10000288'),
(1521, N'Vegetable Based Products / Meals Variety Packs', N'10006221'),
(1522, N'Aquatic Invertebrates – Prepared/Processed (Frozen)', N'10000145'),
(1523, N'Aquatic Invertebrates – Prepared/Processed (Perishable)', N'10000146'),
(1524, N'Aquatic Invertebrates – Prepared/Processed (Shelf Stable)', N'10000147'),
(1525, N'Aquatic Invertebrates – Unprepared/Unprocessed (Frozen)', N'10000148'),
(1526, N'Aquatic Invertebrates – Unprepared/Unprocessed (Perishable)', N'10000149'),
(1527, N'Aquatic Invertebrates – Unprepared/Unprocessed (Shelf Stable)', N'10000150'),
(1528, N'Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Prepared/Processed (Frozen)', N'10000626'),
(1529, N'Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Prepared/Processed (Perishable)', N'10000627'),
(1530, N'Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Prepared/Processed (Shelf Stable)', N'10000628'),
(1531, N'Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Unprepared/Unprocessed (Frozen)', N'10000629'),
(1532, N'Aquatic Invertebrates/Fish/Shellfish/Seafood Mixes – Unprepared/Unprocessed (Perishable)', N'10000630'),
(1534, N'Aquatic Plants Prepared/Processed (Frozen)', N'10000151'),
(1508, N'Popcorn (Shelf Stable)', N'10000252'),
(1561, N'Stock/Bones (Shelf Stable)', N'10000578'),
(1563, N'Chutneys/Relishes (Perishable)', N'10000587'),
(1591, N'Tomato Ketchup/Ketchup Substitutes (Shelf Stable)', N'10006325'),
(1592, N'Seasonings/Preservatives/Extracts Variety Packs', N'10000619'),
(1593, N'Cooking Wines', N'10000052'),
(1594, N'Vinegars', N'10000051'),
(1595, N'Vinegars/Cooking Wines Variety Packs', N'10000618'),
(1596, N'Cigarettes', N'10000185'),
(1597, N'Cigars', N'10000186'),
(1598, N'Electronic Cigarette Accessories', N'10006730'),
(1599, N'Electronic Cigarettes', N'10006729'),
(1600, N'Herbal Chew/Snuff – Non Tobacco', N'10006313'),
(1601, N'Herbal Cigarettes – Non Tobacco', N'10000584'),
(1602, N'Smoking Accessories', N'10000303'),
(1603, N'Tobacco – Chewing/Snuff', N'10000134'),
(1604, N'Tobacco – Loose', N'10000267'),
(1605, N'Tobacco – Solid', N'10000268'),
(1606, N'Tobacco Products/Smoking Accessories Variety Packs', N'10000620'),
(862, N'Fixed Communication Devices Variety Packs', N'10001384'),
(1608, N'Vegetables – Unprepared/Unprocessed (Shelf Stable)', N'10000006'),
(1609, N'Adzuki Beans', N'10006834'),
(1610, N'Beans (Winged)', N'10006336');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1611, N'Broad Beans', N'10005980'),
(1612, N'French/Wax Beans', N'10005976'),
(1613, N'Jack Beans', N'10005981'),
(1590, N'Tomato Ketchup/Ketchup Substitutes (Perishable)', N'10006324'),
(1562, N'Chutneys/Relishes (Frozen)', N'10000586'),
(1589, N'Tomato Ketchup/Ketchup Substitutes (Frozen)', N'10006323'),
(1587, N'Sauces – Cooking (Shelf Stable)', N'10000057'),
(1564, N'Chutneys/Relishes (Shelf Stable)', N'10000180'),
(1565, N'Olives (Perishable)', N'10000238'),
(1566, N'Olives (Shelf Stable)', N'10000239'),
(1567, N'Pickled Vegetables', N'10000244'),
(1568, N'Pickles/Relishes/Chutneys/Olives Variety Packs', N'10000616'),
(1569, N'Dressing/Dips (Frozen)', N'10000583'),
(1570, N'Dressings/Dips (Perishable)', N'10000199'),
(1571, N'Dressings/Dips (Shelf Stable)', N'10000200'),
(1572, N'Food Glazes (Shelf Stable)', N'10000581'),
(1573, N'Mayonnaise/Mayonnaise Substitutes (Frozen)', N'10006317'),
(1574, N'Mayonnaise/Mayonnaise Substitutes (Perishable)', N'10006318'),
(1575, N'Mayonnaise/Mayonnaise Substitutes (Shelf Stable)', N'10006319'),
(1576, N'Mustard (Frozen)', N'10006320'),
(1577, N'Mustard (Perishable)', N'10006321'),
(1578, N'Mustard (Shelf Stable)', N'10006322'),
(1579, N'Other Sauces Dipping/Condiments/Savoury Toppings/Savoury Spreads/Marinades (Frozen)', N'10000577'),
(1580, N'Other Sauces Dipping/Condiments/Savoury Toppings/Savoury Spreads/Marinades (Perishable)', N'10000054'),
(1581, N'Other Sauces Dipping/Condiments/Savoury Toppings/Savoury Spreads/Marinades (Shelf Stable)', N'10000280'),
(1582, N'Pate (Frozen)', N'10000576'),
(1583, N'Pate (Perishable)', N'10000064'),
(1584, N'Pate (Shelf Stable)', N'10000306'),
(1585, N'Sauces – Cooking (Frozen)', N'10000056'),
(1586, N'Sauces – Cooking (Perishable)', N'10000055'),
(1588, N'Sauces/Spreads/Dips/Condiments Variety Packs', N'10000617'),
(1293, N'Fruit – Prepared/Processed (Shelf Stable)', N'10000206'),
(1607, N'Vegetables – Unprepared/Unprocessed (Frozen)', N'10000005'),
(1291, N'Fruit – Prepared/Processed (Frozen)', N'10000204'),
(998, N'Roselle hempplants (Hibiscus sabdariffa var. altissima)', N'10006886'),
(999, N'Sea island cotton plants (Gossypium barbadense)', N'10006883'),
(1000, N'Sisalplants (Agave sisalane)', N'10006875'),
(1001, N'Agarwood trees (Aquilaria malaccensis)', N'10006909'),
(1002, N'Balsam fir trees (Abies balsamea)', N'10006911'),
(1003, N'Dyer''s broom shrubs (Genista tinctoria)', N'10006913'),
(1004, N'Henna trees (Lawsonia inermis)', N'10006915'),
(1005, N'Kamala trees (Mallotus philippensis)', N'10006917');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1006, N'Madder plants (Rubia tinctorum)', N'10006919'),
(1007, N'Olibanum trees (Boswelia)', N'10006924'),
(1008, N'Senegal Rosewood trees (Pterocarpus erinaceus)', N'10006922'),
(1009, N'Turpentine trees (Pistacia terebinthus)', N'10006925'),
(1010, N'Cross Segment Variety Packs', N'10000624'),
(1011, N'Cable Clips/Grommets/Ties', N'10005651'),
(1012, N'Cable Markers', N'10005648'),
(1013, N'Cable Marking Accessories', N'10005674'),
(1014, N'Cable Reels/Pullers', N'10005649'),
(1015, N'Cable/Wire Conduit/Ducting/Raceways', N'10005647'),
(1016, N'Cabling/Wiring Protection/Wrapping', N'10005650'),
(1017, N'Conduit Fittings', N'10005660'),
(1018, N'Audio Visual Cables', N'10005757'),
(1019, N'Computer Cables', N'10005754'),
(1020, N'Satellite Installation Cables', N'10005759'),
(997, N'Rattan palmtrees (Calamus rotang)', N'10006879'),
(1021, N'Telecommunication Cables', N'10005758'),
(996, N'Ramieplants (Boehmeria nivea)', N'10006878'),
(994, N'Pita plants (Agave americana)', N'10006869'),
(971, N'Plantain Banana shrubs (Musa x paradisiaca - AAB)', N'10006936'),
(972, N'Snowbanana trees (Ensete glaucum)', N'10006934'),
(973, N'Guayule plants (Parthenium argentatum)', N'10006907'),
(974, N'Rubbertrees (Hevea brasiliensis)', N'10006892'),
(975, N'Russian dandelion plants (Taraxacum kok-saghyz)', N'10006908'),
(976, N'Aramina fiberplants (Musa textilis)', N'10006888'),
(977, N'Bambooshrubs (Bambuseae)', N'10006877'),
(978, N'China juteplants (Abutilon avicennae)', N'10006868'),
(979, N'Congo Jute plants (Urena lobata)', N'10006890'),
(980, N'Cottonplants (Gossypium hirsutum)', N'10006884'),
(981, N'Flaxplants (Linum usitatissimum)', N'10006887'),
(982, N'Hempplants (Cannabis sativa)', N'10006880'),
(983, N'Henequen plants (Agave fourcroydes )', N'10006872'),
(984, N'Indian flaxplants (Abroma augustum)', N'10006867'),
(985, N'Ixtle or tampico plants (Agave lecheguilla)', N'10006873'),
(986, N'Juteshrubs (Corchorus)', N'10006882'),
(987, N'Kapoktrees (Ceiba pentandra)', N'10006881'),
(988, N'Kenafplants (Hibiscus cannabinus)', N'10006885'),
(989, N'Kyenkyen / Upastrees (Antiaris Africana)', N'10006876'),
(990, N'Maguey plants (Agave cantala)', N'10006870'),
(991, N'Mauritian hempplants (Furcraea foetida)', N'10006871'),
(992, N'Nettleplants (Urtica dioica)', N'10006891'),
(993, N'Other agave hemp plants (Agave letonae)', N'10006874');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (995, N'Raffia palmtrees (Raphia farinifera)', N'10006889'),
(970, N'Lacatan banana shrubs (Musa acuminata × M. balbisiana - AA Group-  Lakatan)', N'10006941'),
(1022, N'Electrical Wires', N'10005541'),
(1024, N'Batteries/Chargers Variety Packs', N'10000704'),
(1053, N'Dimmers', N'10005634'),
(1054, N'Light Bulb Sockets', N'10005633'),
(1055, N'Electrical Lighting - Other', N'10006896'),
(1056, N'Electric Lanterns – Portable', N'10005643'),
(1057, N'Electric Torches/Flashlights', N'10005642'),
(1058, N'Extension Light – Portable', N'10005669'),
(1059, N'Circuit Assemblies/Integrated Circuits', N'10005661'),
(1060, N'Discreet Components', N'10005662'),
(1061, N'Electronic Circuit Accessories', N'10005667'),
(1062, N'Bonding/Grounding Braid', N'10005546'),
(1063, N'Electronic Testers', N'10005742'),
(1064, N'Extension/Power Supply Cords', N'10005559'),
(1065, N'Multimeters', N'10005599'),
(1066, N'Wall Plates (Electrical)', N'10005505'),
(1067, N'Alcohol Making Kits', N'10000142'),
(1068, N'Alcohol Making Supplies', N'10000143'),
(1069, N'Alcoholic Beverages Variety Packs', N'10000591'),
(1070, N'Alcoholic Cordials/Syrups', N'10000589'),
(1071, N'Alcoholic Pre-mixed Drinks', N'10000144'),
(1072, N'Apple/Pear Alcoholic Beverage – Sparkling', N'10000181'),
(1073, N'Apple/Pear Alcoholic Beverage – Still', N'10006327'),
(1074, N'Beer', N'10000159'),
(1075, N'Liqueurs', N'10000227'),
(1052, N'Ballasts/Starters', N'10005481'),
(1023, N'Batteries', N'10000546'),
(1051, N'Light Bulb Changers', N'10005638'),
(1049, N'Lampshades', N'10005635'),
(1025, N'Chargers', N'10000548'),
(1026, N'Connectors (Electrical)', N'10005573'),
(1027, N'Electrical Connection Variety Packs', N'10005572'),
(1028, N'Plugs', N'10000551'),
(1029, N'Sockets/Receptacles/Outlets', N'10005567'),
(1030, N'Adaptors (Electrical)', N'10005496'),
(1031, N'Busbars/Busways', N'10005575'),
(1032, N'Capacitors', N'10005622'),
(1033, N'Circuit Breakers', N'10005576'),
(1034, N'Converters/Inverters/Regulators/Transformers', N'10000547'),
(1035, N'Distribution Boards/Boxes', N'10005583');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1036, N'Electrical Distribution Accessories/Fittings', N'10005577'),
(1037, N'Fuses', N'10000549'),
(1038, N'Multi-use/Universal Electrical Timers/Controllers', N'10005682'),
(1039, N'Relays/Contactors', N'10005570'),
(1040, N'Splitters', N'10005568'),
(1042, N'Switches', N'10005586'),
(1043, N'Terminal Blocks/Strips', N'10005588'),
(1044, N'Lamps – Freestanding', N'10005641'),
(1045, N'Light Bulbs/Tubes/Light-Emitting Diodes', N'10000552'),
(1046, N'Lighting – Fixed', N'10005639'),
(1047, N'Rope/String Lights', N'10005644'),
(1048, N'Lamp Brackets/Fittings', N'10005637'),
(1050, N'Lampstands/Bases', N'10005636'),
(1076, N'Non Grape Fermented Alcoholic Beverages – Sparkling', N'10003689'),
(969, N'Babybanana shrubs (Musa acuminata - AA)', N'10006938'),
(967, N'Pawpaw trees (Asimina)', N'10006933'),
(890, N'Computer Processors', N'10001125'),
(891, N'Computer/Video Games Mass Storage', N'10005683'),
(892, N'Expansion Boards/Cards', N'10001126'),
(893, N'Computer Drives – Replacement Parts/Accessories', N'10001129'),
(894, N'Computer Drives Variety Packs', N'10001131'),
(895, N'Floppy Disc Drives', N'10001132'),
(896, N'Hard Disc Drives', N'10001133'),
(897, N'Optical Drives – Reading Only', N'10001128'),
(898, N'Optical Drives – Reading/Writing', N'10001127'),
(899, N'Swap Drives', N'10001134'),
(900, N'Tape Drives/Streamers', N'10001135'),
(901, N'Zip/Jaz Disk Drives', N'10001136'),
(902, N'Computer Networking Equipment – Replacement Parts/Accessories', N'10001172'),
(903, N'Computer Networking Equipment Variety Packs', N'10001171'),
(904, N'Gateways', N'10001163'),
(905, N'Modems', N'10001164'),
(906, N'Network Access Points', N'10001165'),
(907, N'Network Interface Cards', N'10001167'),
(908, N'Network Routers', N'10001168'),
(909, N'Network Switches', N'10001169'),
(910, N'Network/USB Hubs', N'10001166'),
(911, N'Repeaters', N'10001173'),
(912, N'USB Internet Stick', N'10005831'),
(889, N'Computer Motherboards', N'10001123'),
(913, N'Card Readers', N'10001115'),
(888, N'Computer Memory', N'10001122');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (886, N'Computer Components Variety Packs', N'10001120'),
(1292, N'Fruit – Prepared/Processed (Perishable)', N'10000205'),
(864, N'Intercoms', N'10001189'),
(865, N'Telephone Switchboards', N'10001190'),
(866, N'Telephones', N'10001191'),
(867, N'Communication Radio Sets', N'10001192'),
(868, N'GPS Equipment – Mobile Communications', N'10001193'),
(869, N'GPS Software – Mobile Communications', N'10001194'),
(870, N'Mobile Communication Devices/Services – Replacement Parts', N'10003779'),
(871, N'Mobile Communication Devices/Services Other', N'10001385'),
(872, N'Mobile Phone Pre-pay Vouchers/Cards', N'10001195'),
(873, N'Mobile Phone SIM Cards/SIM Card Adapters', N'10001196'),
(874, N'Mobile Phone Software', N'10001197'),
(875, N'Mobile Phones/Smartphones', N'10001198'),
(876, N'Pagers', N'10001199'),
(877, N'Personal Digital Broadcasters/Trackers', N'10005711'),
(878, N'Two-way Radios', N'10001200'),
(879, N'Sign – Replacement Part/Accessory', N'10006227'),
(880, N'Sign Holders', N'10006226'),
(881, N'Signs, Combination', N'10006225'),
(882, N'Signs, Preprinted', N'10006223'),
(883, N'Signs, Unprinted', N'10006224'),
(884, N'Computer Casing/Housing', N'10001117'),
(885, N'Computer Components – Replacement Parts/Accessories', N'10001118'),
(887, N'Computer Cooling', N'10001121'),
(968, N'Sweetsop/Sugar apple trees (Annona squamosa)', N'10006931'),
(914, N'Computer Casing/Housing Accessories', N'10001116'),
(916, N'Computer Power Supplies', N'10001124'),
(944, N'Scanners', N'10001160'),
(945, N'Web-cameras', N'10001161'),
(946, N'Computer Software (Non Games)', N'10001138'),
(947, N'Computer Software (Non Games) –  Digital', N'10006236'),
(948, N'Computer/Video Game Gaming Software', N'10001137'),
(949, N'Computer/Video Game Gaming Software – Digital', N'10006235'),
(950, N'Computer/Video Game Software Variety Packs', N'10001140'),
(951, N'Computers Other', N'10001142'),
(952, N'Electronic Organisers', N'10001143'),
(953, N'Personal Computers  – Tablets/E-Book Readers', N'10006276'),
(954, N'Personal Computers – All-in-One', N'10006405'),
(955, N'Personal Computers – Desktop/Internet Terminal', N'10001144'),
(956, N'Personal Computers – Portable', N'10001145'),
(957, N'Personal Digital Assistants', N'10001146');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (958, N'Servers', N'10001147'),
(959, N'Smart Watches', N'10006743'),
(960, N'Computers/Video Games Variety Packs', N'10001370'),
(961, N'Console Accessories', N'10005763'),
(962, N'Video Game Consoles – Non Portable', N'10003817'),
(963, N'Video Game Consoles – Portable', N'10003818'),
(964, N'Video Game Consoles – Replacement Parts', N'10003819'),
(965, N'Atemoya trees (Annona x atemoya)', N'10006932'),
(966, N'Cherimoya trees (Annona cherimola)', N'10006927'),
(943, N'Projection Systems', N'10001159'),
(915, N'Computer Docking Ports/Cradles', N'10001109'),
(942, N'Printers', N'10001158'),
(940, N'Keyboard, Voice, Mouse (KVM) Switch', N'10006745'),
(917, N'Computer Stands/Supports', N'10005438'),
(918, N'Computer Tools/Tool Kits', N'10001112'),
(919, N'Computer/Video Game Accessories Variety Packs', N'10001363'),
(920, N'Computer/Video Game Cases/Carriers', N'10001107'),
(921, N'Computer/Video Game Cleaning Products', N'10001108'),
(922, N'Computer/Video Game Headsets', N'10005741'),
(923, N'Computer/Video Game Security Products', N'10001111'),
(924, N'Filters/Covers (Electronic Equipment)', N'10001110'),
(925, N'Mats/Rests – Computing', N'10001113'),
(926, N'Personal Data Assistant/Organiser Stylus', N'10001114'),
(927, N'Personal Video Recorder', N'10006744'),
(928, N'Video Editor', N'10005843'),
(929, N'Computer Graphics Tablets', N'10001149'),
(930, N'Computer Keyboards', N'10001150'),
(931, N'Computer Pointing Devices', N'10001151'),
(932, N'Computer/Video Game Control Devices', N'10001148'),
(933, N'Computer/Video Game Control/Input Devices – Replacement Parts/Accessories', N'10001152'),
(934, N'Computer/Video Game Control/Input Devices Variety Packs', N'10001365'),
(935, N'Digital Pens', N'10005686'),
(936, N'Computer Speakers/Mini Speakers', N'10001154'),
(937, N'Computer/Video Game Monitors', N'10001153'),
(938, N'Computer/Video Game Peripherals – Replacement Parts/Accessories', N'10001155'),
(939, N'Computer/Video Game Peripherals Variety Packs', N'10001367'),
(941, N'Printer Consumables', N'10001156'),
(1077, N'Non Grape Fermented Alcoholic Beverages – Still', N'10000588'),
(1041, N'Surge Suppressors/Protectors', N'10005585'),
(1079, N'Wine – Fortified', N'10000273'),
(1214, N'Indian Limes', N'10006438'),
(1215, N'King Mandarins', N'10006439');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1216, N'Kumquat', N'10006345'),
(1217, N'Lemons', N'10005882'),
(1218, N'Limequats', N'10005885'),
(1219, N'Limes', N'10005884'),
(1078, N'Spirits', N'10000263'),
(1221, N'Mediterranean (Willowleaf) Mandarins', N'10006440'),
(1222, N'Mexican Limes', N'10005883'),
(1223, N'Minneolas and other Tangelos', N'10005880'),
(1224, N'Orangelos', N'10006343'),
(1225, N'Oranges', N'10005889'),
(1226, N'Pummelos', N'10005877'),
(1227, N'Satsuma Mandarins', N'10005887'),
(1228, N'Sweeties', N'10005879'),
(1229, N'Tangerines', N'10005888'),
(1230, N'Tangor', N'10006442'),
(1231, N'Ugli', N'10005881'),
(1232, N'Fruits – Unprepared/Unprocessed (Fresh) Variety Packs', N'10006172'),
(1233, N'Kiwiberries', N'10005938'),
(1234, N'Kiwifruits', N'10005937'),
(1235, N'Bilimbi', N'10005963'),
(1236, N'Breadfruits', N'10005973'),
(1213, N'Honey Pomelos', N'10005878'),
(1237, N'Cape Gooseberries', N'10005965'),
(1212, N'Grapefruits', N'10005876'),
(1210, N'Citron', N'10006866'),
(1187, N'Acai Berries', N'10006759'),
(1188, N'Bilberries', N'10005928'),
(1189, N'Black Currants', N'10006194'),
(1190, N'Blackberries', N'10005923'),
(1191, N'Blueberries', N'10005929'),
(1192, N'Boysenberries', N'10005924'),
(1193, N'Cloudberries', N'10005925'),
(1194, N'Cranberries', N'10005930'),
(1195, N'Elderberries', N'10006432'),
(1196, N'Five-Flavor Berries', N'10006832'),
(1197, N'Goji Berries', N'10006429'),
(1198, N'Gooseberries', N'10005932'),
(1199, N'Hybrids of Berries', N'10006430'),
(1200, N'Jostaberries', N'10005934'),
(1201, N'Lingonberries', N'10006431'),
(1202, N'Loganberries', N'10006346'),
(1203, N'Madrona', N'10006347');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1204, N'Raspberries', N'10005927'),
(1205, N'Red Currants', N'10006193'),
(1206, N'Saskatoon Berries', N'10006354'),
(1207, N'Strawberries', N'10005921'),
(1208, N'Table Grapes', N'10005918'),
(1209, N'Wood Strawberries', N'10005922'),
(1211, N'Clementines', N'10005886'),
(1186, N'Red Bananas', N'10005899'),
(1238, N'Carambola', N'10005961'),
(1240, N'Dates', N'10005959'),
(1268, N'Crabapples', N'10006338'),
(1269, N'Japanese Medlars', N'10005901'),
(1270, N'Medlar', N'10006414'),
(1271, N'Nashi', N'10005902'),
(1272, N'Pears', N'10005903'),
(1273, N'Quinces', N'10006173'),
(1274, N'Ya Pear (Shandong)', N'10006415'),
(1275, N'Apricots', N'10005905'),
(1276, N'Damsons', N'10005909'),
(1277, N'Greengages', N'10005913'),
(1278, N'Japanese Plums', N'10005914'),
(1279, N'Mirabelles', N'10005910'),
(1280, N'Mumes', N'10006831'),
(1281, N'Nectarines', N'10005911'),
(1282, N'Paraguaya', N'10006443'),
(1283, N'Peaches', N'10005912'),
(1284, N'Plumcots', N'10005915'),
(1285, N'Plums', N'10005917'),
(1286, N'Sour Cherries', N'10005907'),
(1287, N'Stemless/Sweet Cherries', N'10005908'),
(1288, N'Stonefruit Hybrids', N'10005916'),
(1289, N'Fruit – Unprepared/Unprocessed (Frozen)', N'10000002'),
(1290, N'Fruit – Unprepared/Unprocessed (Shelf Stable)', N'10000003'),
(1267, N'Apples', N'10005900'),
(1239, N'Cassia', N'10006437'),
(1266, N'Yellow Dragonfruits', N'10005956'),
(1264, N'Pineapples', N'10005935'),
(1241, N'Durian', N'10005972'),
(1242, N'Feijoas', N'10006160'),
(1243, N'Figs', N'10005960'),
(1244, N'Guavas', N'10005971'),
(1245, N'Jackfruits', N'10005974');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1246, N'Jambolan', N'10006434'),
(1247, N'Longan (Dragons Eye)', N'10006435'),
(1248, N'Lychees (Litchi)', N'10005964'),
(1249, N'Mangos', N'10005969'),
(1250, N'Mangosteen', N'10005968'),
(1251, N'Pomegranates', N'10005970'),
(1252, N'Prickly Pears (Barbary Figs)', N'10005967'),
(1253, N'Rambutan', N'10005966'),
(1254, N'Salak (Snake Fruit)', N'10006436'),
(1255, N'Babacos', N'10005955'),
(1256, N'Papayas Formosa', N'10005954'),
(1257, N'Barbadines', N'10005949'),
(1258, N'Curubas', N'10005950'),
(1259, N'Purple Maracujas', N'10005953'),
(1260, N'Sweet Granadilla', N'10005951'),
(1261, N'Yellow Maracujas', N'10005952'),
(1262, N'American Persimmon', N'10005948'),
(1263, N'Kaki/ Sharon Fruits', N'10005946'),
(1265, N'Sweet Pitayas', N'10005957'),
(1185, N'Plantain Bananas', N'10005898'),
(1220, N'Mandarin Hybrids', N'10006441'),
(1183, N'Baby Bananas', N'10005896'),
(1107, N'Vegetable Juice Drinks – Not Ready to Drink (Shelf Stable)', N'10006257'),
(1108, N'Chocolate/Cocoa/Malt – Ready to Drink', N'10000179'),
(1109, N'Dairy/Dairy Substitute Based Drinks – Ready to Drink (Perishable)', N'10000191'),
(1110, N'Dairy/Dairy Substitute Based Drinks – Ready to Drink (Shelf Stable)', N'10000192'),
(1111, N'Drinks Flavoured – Ready to Drink', N'10000201'),
(1112, N'Fruit Juice – Ready to Drink (Perishable)', N'10000219'),
(1113, N'Fruit Juice – Ready to Drink (Shelf Stable)', N'10000220'),
(1114, N'Fruit Juice Drinks – Ready to Drink (Perishable)', N'10000222'),
(1115, N'Fruit Juice Drinks – Ready to Drink (Shelf Stable)', N'10000223'),
(1116, N'Ice', N'10000214'),
(1117, N'Non Alcoholic Beverages Variety Packs – Ready to Drink', N'10000594'),
(1118, N'Packaged Water', N'10000232'),
(1119, N'Sports Drinks – Rehydration (Ready To Drink)', N'10000265'),
(1120, N'Stimulants/Energy Drinks – Ready to Drink', N'10000266'),
(1121, N'Vegetable Juice – Ready to Drink (Perishable)', N'10006251'),
(1122, N'Vegetable Juice – Ready to Drink (Shelf Stable)', N'10006252'),
(1123, N'Vegetable Juice Drinks – Ready to Drink (Perishable)', N'10006255'),
(1124, N'Vegetable Juice Drinks – Ready to Drink (Shelf Stable)', N'10006256'),
(1125, N'Baking/Cooking Mixes (Frozen)', N'10000155'),
(1126, N'Baking/Cooking Mixes (Perishable)', N'10000068');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1127, N'Baking/Cooking Mixes (Shelf Stable)', N'10000156'),
(1128, N'Baking/Cooking Mixes/Supplies Variety Packs', N'10000595'),
(1129, N'Baking/Cooking Supplies (Frozen)', N'10000157'),
(1106, N'Vegetable Juice – Not Ready to Drink (Shelf Stable)', N'10006254'),
(1130, N'Baking/Cooking Supplies (Perishable)', N'10000069'),
(1105, N'Vegetable Juice – Not Ready to Drink (Frozen)', N'10006253'),
(1103, N'Sports Drinks – Rehydration (Not Ready to Drink)', N'10000264'),
(1080, N'Wine – Sparkling', N'10000275'),
(1081, N'Wine – Still', N'10000276'),
(1082, N'Beverages Variety Packs', N'10000623'),
(1083, N'Coffee – Beans/Ground', N'10000111'),
(1084, N'Coffee – Instant', N'10000115'),
(1085, N'Coffee – Ready to Drink', N'10000114'),
(1086, N'Coffee Substitutes – Instant', N'10006311'),
(1087, N'Coffee Substitutes – Ready to Drink', N'10006312'),
(1088, N'Coffee Substitutes – Regular(Non-Instant)', N'10006310'),
(1089, N'Coffee/Tea/Substitutes Variety Packs', N'10000592'),
(1090, N'Fruit Herbal Infusions – Bags/Loose', N'10000119'),
(1091, N'Fruit Herbal Infusions – Instant', N'10000210'),
(1092, N'Fruit Herbal Infusions – Ready to Drink', N'10000313'),
(1093, N'Tea – Bags/Loose', N'10000116'),
(1094, N'Tea – Instant', N'10000117'),
(1095, N'Tea – Ready to Drink', N'10000118'),
(1184, N'Bananas', N'10005897'),
(1097, N'Dairy/Dairy Substitute Based Drinks – Not Ready to Drink (Shelf Stable)', N'10000310'),
(1098, N'Drinks Flavoured – Not Ready to Drink', N'10000202'),
(1099, N'Fruit Juice – Not Ready to Drink (Frozen)', N'10000307'),
(1100, N'Fruit Juice – Not Ready to Drink (Shelf Stable)', N'10000308'),
(1101, N'Fruit Juice Drinks – Not Ready to Drink (Shelf Stable)', N'10000309'),
(1102, N'Non Alcoholic Beverages Variety Packs – Not Ready to Drink', N'10000593'),
(1104, N'Stimulants/Energy Drinks – Not Ready to Drink', N'10000311'),
(1131, N'Baking/Cooking Supplies (Shelf Stable)', N'10000158'),
(1096, N'Chocolate/Cocoa/Malt – Not Ready to Drink', N'10000178'),
(1133, N'Biscuits/Cookies (Perishable)', N'10000160'),
(1160, N'Cereal/Muesli Bars', N'10000287'),
(1161, N'Cereals Products – Not Ready to Eat (Frozen)', N'10006250'),
(1162, N'Cereals Products – Not Ready to Eat (Shelf Stable)', N'10000285'),
(1163, N'Cereals Products – Ready to Eat (Shelf Stable)', N'10000284'),
(1164, N'Processed Cereal Products Variety Packs', N'10000600'),
(1165, N'Chewing Gum', N'10006390'),
(1166, N'Chocolate and Chocolate/Sugar Candy Combinations – Confectionery', N'10000045'),
(1167, N'Confectionery Products Variety Packs', N'10000602');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] ON;
INSERT INTO [dbo].[BrickCategories] ([id], [brick], [brick_id])
VALUES (1168, N'Sugar Candy/Sugar Candy Substitutes Confectionery', N'10000047'),
(1169, N'Confectionery/Sugar Sweetening Products Variety Packs', N'10000622'),
(1170, N'Sugar/Sugar Substitutes (Shelf Stable)', N'10000043'),
(1171, N'Sugars/Sugar Substitute Products Variety Packs', N'10000603'),
(1172, N'Syrup/Treacle/Molasses (Shelf Stable)', N'10000044'),
(1173, N'Food/Beverage/Tobacco Variety Packs', N'10000590'),
(1174, N'Annona Other', N'10006433'),
(1176, N'Cherimoya', N'10005939'),
(1177, N'Soursop', N'10005942'),
(1178, N'Sugar Apples', N'10005940'),
(1179, N'Avocados – Pebbled Peel (Hass-Type)', N'10006168'),
(1180, N'Avocados – Smooth Peel', N'10006169'),
(1181, N'Finger Avocados', N'10006167'),
(1132, N'Biscuits/Cookies (Frozen)', N'10000304'),
(1182, N'Apple Bananas', N'10005895'),
(1159, N'Cereal Products – Ready to Eat (Perishable)', N'10000286'),
(1158, N'Grains/Flour Variety Packs', N'10000599'),
(1175, N'Bullock Hearts', N'10005941'),
(1156, N'Grains/Cereal – Ready to Eat – (Perishable)', N'10000316'),
(1134, N'Biscuits/Cookies (Shelf Stable)', N'10000161'),
(1136, N'Dried Breads (Frozen)', N'10000305'),
(1137, N'Dried Breads (Shelf Stable)', N'10000166'),
(1138, N'Bread (Frozen)', N'10000163'),
(1139, N'Bread (Perishable)', N'10000164'),
(1135, N'Biscuits/Cookies Variety Packs', N'10000596'),
(1140, N'Bread (Shelf Stable)', N'10000165'),
(1141, N'Bread/Bakery Products Variety Packs', N'10000598'),
(1142, N'Pies/Pastries/Pizzas/Quiches – Savoury (Frozen)', N'10000248'),
(1144, N'Pies/Pastries/Pizzas/Quiches – Savoury (Shelf Stable)', N'10000250'),
(1145, N'Cakes – Sweet (Frozen)', N'10000170'),
(1143, N'Pies/Pastries/Pizzas/Quiches – Savoury (Perishable)', N'10000249'),
(1147, N'Cakes – Sweet (Shelf Stable)', N'10000172'),
(1155, N'Grains/Cereal – Not Ready to Eat – (Shelf Stable)', N'10000211'),
(1154, N'Grains/Cereal – Not Ready to Eat – (Perishable)', N'10000315'),
(1153, N'Grains/Cereal – Not Ready to Eat – (Frozen)', N'10000314'),
(1146, N'Cakes – Sweet (Perishable)', N'10000171'),
(1151, N'Sweet Bakery Products Variety Packs', N'10000597'),
(1152, N'Flour – Cereal/Pulse (Shelf Stable)', N'10000203'),
(1149, N'Pies/Pastries – Sweet (Perishable)', N'10000246'),
(1148, N'Pies/Pastries – Sweet (Frozen)', N'10000245'),
(1150, N'Pies/Pastries – Sweet (Shelf Stable)', N'10000247'),
(1157, N'Grains/Cereal – Ready to Eat – (Shelf Stable)', N'10000319');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'brick', N'brick_id') AND [object_id] = OBJECT_ID(N'[dbo].[BrickCategories]'))
    SET IDENTITY_INSERT [dbo].[BrickCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] ON;
INSERT INTO [dbo].[FamilyCategories] ([ID], [FamilyCode], [FamilyDefinition], [FamilyTitle], [SegmentCode])
VALUES (95, 73050000, NULL, N'Tableware', 75000000),
(96, 81010000, NULL, N'Lawn/Garden Supplies', 81000000),
(97, 89020000, NULL, N'Live Animals', 89000000),
(98, 88030000, NULL, N'Lubricants Variety Packs', 88000000),
(101, 96010000, NULL, N'Currency/Postage/Certificates', 96000000),
(100, 88020000, NULL, N'Lubricants/Protective Compounds Storage/Transfer', 88000000),
(107, 79010000, NULL, N'Plumbing/Heating/Ventilation/Air Conditioning', 79000000),
(103, 64010000, NULL, N'Personal Accessories', 64000000),
(104, 10100000, NULL, N'Pet Care', 10000000),
(105, 10120000, NULL, N'Pet Care/Food Variety Packs', 10000000),
(106, 10110000, NULL, N'Pet Food/Drinks', 10000000),
(94, 73040000, NULL, N'Kitchenware', 75000000),
(108, 99010000, NULL, N'Postmortem Products', 99000000),
(109, 98020000, NULL, N'Formed Raw Material', 98000000),
(102, 61010000, NULL, N'Musical Instruments/Accessories', 61000000),
(93, 75030000, NULL, N'Ornamental Furnishings', 75000000),
(82, 93020000, NULL, N'Cut Greens', 93000000),
(91, 75020000, NULL, N'Fabric/Textile Furnishings', 75000000),
(75, 51160000, NULL, N'Pharmaceutical Drugs', 51000000),
(110, 98010000, NULL, N'Unformed Raw Material', 98000000),
(76, 51170000, NULL, N'Veterinary Healthcare', 51000000),
(77, 72010000, NULL, N'Major Domestic Appliances', 72000000),
(78, 72020000, NULL, N'Small Domestic Appliances', 72000000),
(79, 93100000, NULL, N'Bouquets', 93000000),
(80, 93050000, NULL, N'Bulbs/Corms/Rhizomes/Tubers', 93000000),
(92, 75010000, NULL, N'Household/Office Furniture', 75000000),
(81, 93010000, NULL, N'Cut Flowers', 93000000),
(84, 93040000, NULL, N'Live Plants (Genus H thru Z)', 93000000),
(85, 93060000, NULL, N'Plants Variety Packs', 93000000),
(86, 93110000, NULL, N'Seedlings - Ready to Grow', 93000000),
(87, 93070000, NULL, N'Seeds/Spores', 93000000),
(88, 93080000, NULL, N'Shrubs/Trees', 93000000),
(89, 93090000, NULL, N'Vegetables/Fungi Plants', 93000000),
(90, 75050000, NULL, N'Baby Furnishings', 75000000),
(83, 93030000, NULL, N'Live Plants (Genus A thru G)', 93000000),
(111, 85010000, NULL, N'Safety/Protection - DIY', 85000000),
(136, 92040000, NULL, N'Storage/Haulage Aids', 92000000),
(113, 91020000, NULL, N'Environmental Safety/Security', 91000000),
(134, 62070000, NULL, N'Stationery/Office Machinery/Occasion Supplies Variety Packs', 62000000),
(135, 92010000, NULL, N'Storage Bottles/Cylinders/Barrels (Empty)', 92000000),
(137, 92020000, NULL, N'Storage/Haulage Boxes/Crates/Trays (Empty)', 92000000),
(138, 92030000, NULL, N'Storage/Haulage Freight Containers (Empty)', 92000000);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] ON;
INSERT INTO [dbo].[FamilyCategories] ([ID], [FamilyCode], [FamilyDefinition], [FamilyTitle], [SegmentCode])
VALUES (139, 60010000, NULL, N'Textual/Printed/Reference Materials', 60000000),
(140, 84010000, NULL, N'Tool Storage/Workshop Aids', 84000000),
(141, 80010000, NULL, N'Tools/Equipment - Hand', 80000000),
(142, 82010000, NULL, N'Tools/Equipment - Power', 82000000),
(143, 86020000, NULL, N'Service Provided Gambling Products', 86000000),
(144, 86010000, NULL, N'Toys/Games', 86000000),
(145, 77040000, NULL, N'Aircraft', 77000000),
(146, 77010000, NULL, N'Automotive Accessories and Maintenance', 77000000),
(147, 77030000, NULL, N'Cars and Motorcycles', 77000000),
(148, 77050000, NULL, N'Specialty Vehicles', 77000000),
(74, 51150000, NULL, N'Medical Devices', 51000000),
(133, 62060000, NULL, N'Stationery/Office Machinery', 62000000),
(132, 62050000, NULL, N'Greeting Cards/Gift Wrap/Occasion Supplies', 62000000),
(131, 71010000, NULL, N'Sports Equipment', 71000000),
(130, 71020000, NULL, N'Baby Exercisers/Transportation', 71000000),
(114, 91030000, NULL, N'Home/Business Safety/Security/Surveillance', 91000000),
(115, 91010000, NULL, N'Personal Safety/Security', 91000000),
(116, 95030000, NULL, N'Cleaning Services', 95000000),
(117, 95040000, NULL, N'Communication Services', 95000000),
(118, 95160000, NULL, N'Dispensing/Vending Machines', 95000000),
(119, 95050000, NULL, N'Educational & Entertainment Services', 95000000),
(120, 95060000, NULL, N'Energy and Environmental Services', 95000000),
(112, 91050000, NULL, N'Baby Safety/Security/Surveillance', 91000000),
(121, 95070000, NULL, N'Financial Services', 95000000),
(123, 95120000, NULL, N'Maintenance/Repair and Installation Services', 95000000),
(124, 95130000, NULL, N'Medical and Beauty Care Services', 95000000),
(125, 95080000, NULL, N'Packaging/Storage Services', 95000000),
(126, 95090000, NULL, N'Postal Services', 95000000),
(127, 95100000, NULL, N'Scientific and Technological Services', 95000000),
(128, 95140000, NULL, N'Transportation Services', 95000000),
(129, 95150000, NULL, N'Travel Services', 95000000),
(122, 95110000, NULL, N'Food/Drink and Accommodation Services', 95000000),
(73, 51130000, NULL, N'Home Diagnostics', 51000000),
(99, 88010000, NULL, N'Lubricants/Protective Compounds', 88000000),
(71, 51100000, NULL, N'Health Treatments/Aids', 51000000),
(20, 47220000, NULL, N'Industrial Cleaning', 47000000),
(21, 47120000, NULL, N'Insect/Pest/Allergen Control', 47000000),
(22, 47210000, NULL, N'Waste Management Products', 47000000),
(23, 67030000, NULL, N'Activewear', 67000000),
(24, 67010000, NULL, N'Clothing', 67000000),
(25, 67050000, NULL, N'Protective Wear', 67000000),
(19, 47200000, NULL, N'Cleaning/Hygiene Supplies', 47000000);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] ON;
INSERT INTO [dbo].[FamilyCategories] ([ID], [FamilyCode], [FamilyDefinition], [FamilyTitle], [SegmentCode])
VALUES (26, 67020000, NULL, N'Sleepwear', 67000000),
(28, 67040000, NULL, N'Underwear', 67000000),
(29, 66010000, NULL, N'Communications', 66000000),
(30, 65010000, NULL, N'Computers/Video Games', 65000000),
(31, 94020000, NULL, N'Crops for Food Production', 94000000),
(32, 94010000, NULL, N'Crops not for food or feed (animal and fish)', 94000000),
(33, 94030000, NULL, N'Grass and Other Crops for Animal Feed or for Soil Improvement', 94000000),
(27, 67060000, NULL, N'Swimwear', 67000000),
(18, 47190000, NULL, N'Cleaning/Hygiene Products Variety Packs', 47000000),
(17, 47100000, NULL, N'Cleaning Products', 47000000),
(15, 83010000, NULL, N'Building Products', 83000000),
(72, 51140000, NULL, N'Healthcare Variety Packs', 51000000),
(1, 70010000, NULL, N'Arts/Crafts/Needlework Supplies', 70000000),
(2, 68020000, NULL, N'Photography/Optics', 68000000),
(3, 68010000, NULL, N'Audio Visual Equipment', 68000000),
(4, 68040000, NULL, N'Audio Visual Media', 68000000),
(5, 68050000, NULL, N'Audio Visual/Photography Variety Packs', 68000000),
(6, 68030000, NULL, N'In-car Electronics', 68000000),
(7, 53220000, NULL, N'Beauty/Personal Care/Hygiene Variety Packs', 53000000),
(8, 53200000, NULL, N'Body Products', 53000000),
(9, 53160000, NULL, N'Cosmetics/Fragrances', 53000000),
(10, 53140000, NULL, N'Hair Products', 53000000),
(11, 53240000, NULL, N'Maternity Products', 53000000),
(12, 53180000, NULL, N'Personal Hygiene Products', 53000000),
(13, 53230000, NULL, N'Personal Intimacy', 53000000),
(14, 53130000, NULL, N'Skin Products', 53000000),
(34, 58010000, NULL, N'Cross Segment', 58000000),
(35, 78040000, NULL, N'Electrical Cabling/Wiring', 78000000),
(16, 74010000, NULL, N'Camping', 74000000),
(37, 78030000, NULL, N'Electrical Lighting', 78000000),
(57, 50340000, NULL, N'Nuts/Seeds - Unprepared/Unprocessed (In Shell)', 50000000),
(58, 50330000, NULL, N'Nuts/Seeds - Unprepared/Unprocessed (Perishable)', 50000000),
(59, 50150000, NULL, N'Oils/Fats Edible', 50000000),
(60, 50190000, NULL, N'Prepared/Preserved Foods', 50000000),
(61, 50170000, NULL, N'Seasonings/Preservatives/Extracts', 50000000),
(63, 50290000, NULL, N'Vegetables - Unprepared/Unprocessed (Frozen)', 50000000),
(56, 50130000, NULL, N'Milk/Butter/Cream/Yogurts/Cheese/Eggs/Substitutes', 50000000),
(64, 50320000, NULL, N'Vegetables - Unprepared/Unprocessed (Shelf Stable)', 50000000),
(66, 63010000, NULL, N'Footwear', 63000000),
(67, 87020000, NULL, N'Fuel Storage/Transfer', 87000000),
(68, 87010000, NULL, N'Fuels/Fuel Additives', 87000000),
(69, 51110000, NULL, N'Family Planning', 51000000);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] ON;
INSERT INTO [dbo].[FamilyCategories] ([ID], [FamilyCode], [FamilyDefinition], [FamilyTitle], [SegmentCode])
VALUES (70, 51120000, NULL, N'Health Enhancement', 51000000),
(36, 78020000, NULL, N'Electrical Connection/Distribution', 78000000),
(65, 50260000, NULL, N'Vegetables (Non Leaf) - Unprepared/Unprocessed (Fresh)', 50000000),
(55, 50240000, NULL, N'Meat/Poultry/Other Animals', 50000000),
(62, 50210000, NULL, N'Tobacco/Cannabis/Smoking Accessories', 50000000),
(43, 50160000, NULL, N'Confectionery/Sugar Sweetening Products', 50000000),
(54, 50390000, NULL, N'Meat/Fish/Seafood Substitutes', 50000000),
(39, 78060000, NULL, N'General Electrical Hardware', 78000000),
(40, 50200000, NULL, N'Beverages', 50000000),
(41, 50180000, NULL, N'Bread/Bakery Products', 50000000),
(42, 50220000, NULL, N'Cereal/Grain/Pulse Products', 50000000),
(44, 50120000, NULL, N'Fish and Seafood', 50000000),
(45, 50230000, NULL, N'Food/Beverage/Tobacco Variety Packs', 50000000),
(38, 78050000, NULL, N'Electronic Communication Components', 78000000),
(46, 50360000, NULL, N'Fresh Garnish (Food)', 50000000),
(47, 50250000, NULL, N'Fruits - Unprepared/Unprocessed (Fresh)', 50000000),
(48, 50270000, NULL, N'Fruits - Unprepared/Unprocessed (Frozen)', 50000000),
(49, 50310000, NULL, N'Fruits - Unprepared/Unprocessed (Shelf Stable)', 50000000),
(50, 50370000, NULL, N'Fruits/Vegetables Fresh & Fresh Cut', 50000000),
(51, 50380000, NULL, N'Fruits/Vegetables Fresh Cut', 50000000),
(52, 50100000, NULL, N'Fruits/Vegetables/Nuts/Seeds Prepared/Processed', 50000000),
(53, 50350000, NULL, N'Leaf Vegetables - Unprepared/Unprocessed (Fresh)', 50000000);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'FamilyCode', N'FamilyDefinition', N'FamilyTitle', N'SegmentCode') AND [object_id] = OBJECT_ID(N'[dbo].[FamilyCategories]'))
    SET IDENTITY_INSERT [dbo].[FamilyCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] ON;
INSERT INTO [dbo].[NetContents] ([id], [code], [description], [name])
VALUES (105, N'LD', N'', N'Litre per day'),
(106, N'LNE	', N'The indication of the count of printed lines included on a paper communication (e.g. telegram) for invoicing purposes.', N'Printed line count'),
(104, N'LBR', N'A unit of measure defining the number of litres per day.', N'Pound'),
(117, N'MMQ', N'A unit of measure expressed in cubic milimetres.', N'cubic millimetre'),
(107, N'LUX', N'Unit of measure of illumination (it corresponds to the illumination of a surface which normally and uniformly receives a light flow of 1 lumen per square meter).', N'lux'),
(102, N'KWT', N'', N'kilowatt'),
(103, N'L2', N'Unit of measure expressed in litre per minute.', N'litre per minute'),
(108, N'M4', N'A unit of measure expressed as a monetary amount.', N'Monetary value'),
(116, N'MMK', N'A unit to measure a surface equal to one millionth of a quadrate', N'square millimetre'),
(110, N'MAW', N'', N'megawatt'),
(111, N'MC', N'One millionth of a gram.', N'microgram'),
(112, N'MCU', N'Unit of measure for radioactivity.', N'millicurie'),
(113, N'MGM', N'', N'milligram'),
(114, N'MHZ', N'', N'megahertz'),
(115, N'MIN', N'', N'minute'),
(101, N'KWH', N'', N'kilowatt hour'),
(109, N'MAL', N'', N'mega litre'),
(100, N'KVT', N'', N'kilovolt'),
(82, N'HTZ', N'One cycle per second.', N'hertz'),
(98, N'KTM', N'', N'kilometre');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] ON;
INSERT INTO [dbo].[NetContents] ([id], [code], [description], [name])
VALUES (118, N'MMT', N'', N'millimetre'),
(81, N'HMT', N'A unit of linear measure equal to 10 E2 metres.', N'hectometre'),
(83, N'HUR', N'A unit of measure expressed in square inch', N'hour'),
(84, N'INH', N'Inch (25,4 mm)', N'inch'),
(85, N'INK', N'', N'Square inch'),
(86, N'JM', N'', N'Megajoule per cubic metre'),
(87, N'JOU', N'', N'joule'),
(88, N'K51', N'', N'Kilocalorie (mean)'),
(89, N'KB', N'', N'kilocharacter'),
(90, N'KBA', N'', N'kilobar'),
(91, N'KEL', N'', N'kelvin'),
(92, N'KHZ', N'', N'kilohertz'),
(93, N'KJO', N'', N'kilojoule'),
(94, N'KL', N'A measure of weight in terms of kilogram per metre.', N'kilogram per metre'),
(95, N'KMH', N'A unit of measure expressed in kilometre per hour.', N'kilometre per hour'),
(96, N'KMQ', N'A measure of weight in terms of kilogram per cubic metre.', N'kilogram per cubic metre'),
(97, N'KPA', N'Unit of measure expressed in kilopascal.', N'kilopascal'),
(99, N'KVA', N'A unit of electric power.', N'kilovolt - ampere'),
(119, N'MON', N'The expression of a month as a measure unit.', N'month'),
(155, N'WTT', N'', N'watt'),
(121, N'MQH', N'A unit of measure defining the number of cubic metres per hour.', N'Cubic metre per hour'),
(143, N'RJH', N'A unit of force equal to 10 Newton.', N'Decanewton'),
(144, N'RPM', N'', N'revolutions per minute'),
(145, N'RTO', N'', N'Ratio'),
(146, N'SEC	', N'', N'second'),
(147, N'SMI', N'A unit of measure expressed in mile', N'Mile (statute mile)'),
(148, N'ST', N'Metric ton (1000kg)', N'sheet'),
(149, N'TNE', N'A unit of count defining the number of tablets (tablet: a small flat or compressed solid object). Dosage form for pharmaceuticals, pressed or compacted from a powder into a solid dose.', N'tonne (metric ton)'),
(142, N'QTI', N'Quart UK (1,1136523 dm3)', N'quart (UK)'),
(150, N'U2', N'', N'tablet'),
(152, N'VI', N'Small glass container. E.g. for a liquid medicine or perfume.', N'vial'),
(153, N'VLT', N'', N'volt'),
(154, N'WHR', N'', N'watt hour'),
(80, N'HLT', N'', N'hectolitre'),
(156, N'YDK', N'A unit of measure expressed in square yard', N'Square yard'),
(157, N'YRD', N'Yard (0,9144 m)', N'yard'),
(158, N'ZP', N'The indication of a page as a measurement unit for invoicing purposes, e.g. fax pages.', N'page'),
(151, N'UI', N'A measure pertaining to a predefined activity.', N'Unit of activity, predefined'),
(141, N'QAN', N'', N'quarter (of a year)'),
(140, N'PTN', N'The identification of the number of portions (doses in medical terms) into which a complete product may be broken into for serving purposes, e.g. a pie with 6 portions, a liquid medicine with 20 doses.', N'Portion '),
(139, N'PTI', N'Pint UK (0,568262 dm3)', N'pint (UK)'),
(122, N'MTK', N'', N'square metre');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] ON;
INSERT INTO [dbo].[NetContents] ([id], [code], [description], [name])
VALUES (123, N'MTQ', N'', N'cubic metre'),
(124, N'MTR', N'', N'metre'),
(125, N'MTS', N'A unit of speed expressed in metres per second.', N'Metre per second'),
(126, N'MWH', N'', N'megawatt hour (1000 kW.h)'),
(127, N'NAR', N'', N'number of articles'),
(128, N'NEW', N'The SI unit of force, equal to the force that would give a mass of one kilogram an acceleration of one metre per second.', N'newton'),
(129, N'NIU', N'A unit of count defining the number of international units.', N'number of international units'),
(130, N'NRL', N'', N'number of rolls'),
(131, N'ONZ', N'Ounce GB, US (28,349523 g)', N'ounce'),
(132, N'OZA', N'Fluid ounce US (29,5735 cm3)', N'fluid ounce (US)'),
(133, N'OZI', N'Fluid ounce UK (28,413 cm3)', N'fluid ounce (UK)'),
(134, N'P1', N'This code is used to indicate measurements in terms of percentages, e.g. the relative humidity (code RA in data element 6313) is 52%.', N'percent'),
(135, N'PA', N'', N'packet'),
(136, N'PAL', N'The SI unit of pressure, equal to one Newton per square metre.', N'pascal'),
(137, N'PF', N'A number of articles expressed in terms of pallets.', N'pallet (lift)'),
(138, N'PR', N'Two articles which belong together but are not necessarily identical.', N'pair'),
(120, N'MPA', N'A unit of measure expressed in Megapascal.', N'megapascal'),
(79, N'H87', N'A unit of count defining the number of pieces (piece: a single item, article or exemplar).', N'Piece'),
(68, N'FAH', N'', N'degree Fahrenheit'),
(77, N'GV', N'', N'gigajoule'),
(21, N'A86', N'Hertz multiplied by 10*9.', N'gigahertz'),
(22, N'A99', N'A unit of information equal to one binary digit.', N'Bit'),
(23, N'ACR', N'Acre (4840 yd2)', N'acre'),
(24, N'AD', N'A unit of information stored in a computer, equal to eight bits', N'byte'),
(25, N'AMH', N'Ampere-hour (3,6kC)', N'ampere hour'),
(26, N'AMP', N'', N'ampere'),
(27, N'ANN', N'The expression of a year as a measure unit.', N'year'),
(20, N'A25', N'', N'cheval vapeur'),
(28, N'APZ', N'', N'Troy ounce or apothecary ounce'),
(30, N'ASU', N'Alcoholic strength expressed by volume.', N'alcoholic strength by volume'),
(31, N'AV', N'Encaspuled dosage form for pharmaceuticals.', N'capsule'),
(32, N'B13', N'A unit of measure of heat energy expressed in joule per square metre.', N'Joule per square metre'),
(33, N'B17', N'A unit of count defining the number of entries made to the credit side of an account', N'Credit'),
(34, N'BAR', N'A unit of measure equal to 106 dines per square centimeter.', N'bar'),
(35, N'BTU', N'British thermal unit (1,055 kilojoules)', N'British thermal unit'),
(36, N'C0', N'Unit of measure for telephone calls. Code value is C0 (C Zero).', N'call'),
(29, N'ASM', N'Alcoholic strength expressed by mass.', N'alcoholic strength by mass'),
(37, N'C60', N'Unit of measure expressed in Ohm centimetre.', N'ohm centimetre'),
(19, N'4P', N'', N'newton per metre'),
(17, N'4L', N'A unit of computer memory equal to 1.048.576 (i.e. 2 power 20) bytes.', N'megabyte'),
(1, N'GRM', N'', N'gram'),
(2, N'LTR', N'Litre (1 dm3)', N'litre');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] ON;
INSERT INTO [dbo].[NetContents] ([id], [code], [description], [name])
VALUES (3, N'MLT', N'', N'millilitre'),
(4, N'CLT', N'A unit of volume equal to one hundreth of a liter.', N'centilitre'),
(5, N'CMT', N'', N'centimetre'),
(6, N'KGM', N'', N'kilogram'),
(7, N'23', N'g/cm3 as a unit of measure for the density of gas. This is necessary for dangerous substance articles for determination of the quantities that can be stored together on the shelf.', N'gram per cubic centimetre'),
(18, N'4O', N'One millionth of a farad. A farad is the capacitance of a capacitor between the plates of which a potential of 1 volt is created by a charge of 1 Coulomb.', N'microfarad'),
(8, N'25', N'A measure of weight in terms of gram per square centimetre.', N'gram per square centimetre'),
(10, N'37', N'', N'ounce per square foot'),
(11, N'59', N'', N'part per million'),
(78, N'GWH', N'Gigawatt-hour (1 million kW/h)', N'gigawatt hour'),
(13, N'001', N'', N'Barrel (205 litres, 45 gallons) (GS1 Temporary Code)'),
(14, N'2N', N'', N'decibel'),
(15, N'2X', N'A measure of speed in terms of metres per minute.', N'metre per minute'),
(16, N'4K', N'', N'milliampere'),
(9, N'28', N'Unit of measure expressed in kilogram per square metre.', N'kilogram per square metre'),
(38, N'C79', N'A unit of accumulated energy of 1000 volt amperes over a period of one hour.', N'Kilovolt Ampere Hour'),
(12, N'64', N'A unit of measure expressed in pound per square inch', N'Pound per square inch, gauge'),
(40, N'CEL', N'', N'degree celsius'),
(62, N'E34', N'A unit of information equal to 10 E9 bytes.', N'Gigabyte'),
(63, N'E37', N'A unit of count defining the number of pixels (pixel: picture element).', N'Pixel'),
(64, N'E38', N'A unit of count equal to 10 E6 (1000000) pixels (picture elements).', N'Megapixel'),
(65, N'E39', N'A unit of information defining the number of dots per linear inch as a measure of the resolution or sharpness of an image.', N'Dots per inch'),
(66, N'EA', N'', N'each'),
(67, N'EV', N'A unit of measure pertaining to the number of envelopes.', N'envelope'),
(69, N'FOT', N'Foot (0,3048 m)', N'foot'),
(70, N'FP', N'A unit of measure expressed in pound per square foot', N'Pound per square foot'),
(71, N'FTK', N'A unit of measure expressed in square foot', N'Square foot'),
(72, N'FTQ', N'', N'cubic foot'),
(73, N'GL', N'', N'gram per litre'),
(74, N'GLI', N'Gallon (4,546092 dm3)', N'gallon (UK)'),
(75, N'GM', N'Unit of measure of grams per square metre.', N'gram per square metre'),
(76, N'GRO', N'A unit of measure of 12 dozens.', N'gross'),
(39, N'CDL', N'Unit of measure of light intensity.', N'candela'),
(61, N'E32', N'A unit of count defining the number of litres per hour.', N'Litre per hour'),
(59, N'E27', N'A unit of count defining the number of doses (dose: a definite quantity of a medicine or drug).', N'Dose'),
(60, N'E31', N'A unit of count defining the number of square metres per litre.', N'Square metre per litre'),
(57, N'E10', N'A unit of measure used in meteorology and engineering to measure the demand for heating or cooling over a given period of days.', N'Degree day'),
(41, N'CF2', N'Colony forming units per gram is a unit of measure for micro-organisms, such as bacteria, in a food item. Micro-organisms form colonies that are be counted under determined conditions', N'Colony forming unit per gram '),
(42, N'CMK', N'', N'square centimetre'),
(43, N'CMQ', N'A system of units for the measurement of volume based on the cubic centimetre.', N'cubic centimetre'),
(44, N'D19', N'Unit of measure of thermal insulance expressed in square metre kelvin per watt.', N'Square metre kelvin per watt'),
(45, N'D21', N'Unit of measure expressed in square metre per kilogram.', N'square metre per kilogram');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] ON;
INSERT INTO [dbo].[NetContents] ([id], [code], [description], [name])
VALUES (46, N'D32', N'A unit of measure expressed in terawatt hour', N'Terawatt hour'),
(47, N'D5', N'A unit of measure expressed in kilogram per square centimetre', N'Kilogram per square centimetre'),
(48, N'D55', N'Unit of measure of thermal conductance expressed in watt per square metre kelvin.', N'Watt per square metre kelvin'),
(58, N'E11', N'A unit of heat energy equal to one thousand million calories.', N'Gigacalorie'),
(49, N'D68', N'A unit of count defining the number of words.', N'Number of Words'),
(50, N'DAY', N'The expression of a day as a measure unit', N'day'),
(51, N'DD', N'Unit of measure of temperature.', N'degree'),
(52, N'DMQ', N'Unit of measure expressed in cubic decimetre.', N'cubic decimetre'),
(53, N'DMT', N'', N'decimetre'),
(54, N'DRG', N'Number of dragées (coated tablets) contained in the item''s package as a measurement unit.', N'Dragée'),
(55, N'DZN', N'A unit of measure of 12 or group of 12.', N'dozen'),
(56, N'E09', N'A unit of power load delivered at the rate of one thousandth of an ampere over a period of one hour.', N'Milliampere hour');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'code', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[NetContents]'))
    SET IDENTITY_INSERT [dbo].[NetContents] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[PackageLevels]'))
    SET IDENTITY_INSERT [dbo].[PackageLevels] ON;
INSERT INTO [dbo].[PackageLevels] ([id], [description], [name])
VALUES (4, N'Contains more than one type of each, and must contain more than one GTIN. The case can contain eaches or inner packs.', N'Mixed Case'),
(5, N'A shipping unit that contains either cases, inner packs, or eaches. It must contain one GTIN regardless of the number of items in the grouping.', N'Pallet'),
(7, N'', N'Case as Each'),
(3, N'A standard shipping unit that contains eaches (packaged either individually or grouped as an inner pack). All of the items in a case must have the same GTIN.', N'Case'),
(6, N'A shipping unit that can contain any combination of cases, inner packs, and/or eaches and must contain more than one GTIN.', N'Mixed Pallet'),
(1, N'The lowest level of the item hierarchy intended or labeled for individual resale. Generally this is the consumer unit sold at check out or online.', N'Each'),
(2, N'Each units may be packed into inner packs, which are then packed into a case. Most items do not have an inner pack', N'Inner Pack');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'description', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[PackageLevels]'))
    SET IDENTITY_INSERT [dbo].[PackageLevels] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[PackagingTypes]'))
    SET IDENTITY_INSERT [dbo].[PackagingTypes] ON;
INSERT INTO [dbo].[PackagingTypes] ([id], [name])
VALUES (25, N'Glass'),
(24, N'Jar'),
(23, N'Rack'),
(22, N'Plastic bag'),
(21, N'Paper bag'),
(19, N'Tablet'),
(18, N'Shrinkwrap'),
(17, N'Roll'),
(16, N'Tray'),
(15, N'net'),
(14, N'Multipack'),
(13, N'Foil'),
(12, N'Envelope'),
(20, N'Tube'),
(10, N'Cardboard carrier'),
(9, N'Can'),
(8, N'Cage'),
(7, N'Box'),
(6, N'Bucket'),
(5, N'Bottle'),
(4, N'Barrel'),
(3, N'Basket'),
(2, N'Bag');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[PackagingTypes]'))
    SET IDENTITY_INSERT [dbo].[PackagingTypes] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[PackagingTypes]'))
    SET IDENTITY_INSERT [dbo].[PackagingTypes] ON;
INSERT INTO [dbo].[PackagingTypes] ([id], [name])
VALUES (1, N'Aerosol'),
(11, N'Cup');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[PackagingTypes]'))
    SET IDENTITY_INSERT [dbo].[PackagingTypes] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Roles]'))
    SET IDENTITY_INSERT [dbo].[Roles] ON;
INSERT INTO [dbo].[Roles] ([id], [name])
VALUES (1, N'Member'),
(2, N'Admin'),
(3, N'SuperAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Roles]'))
    SET IDENTITY_INSERT [dbo].[Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'SegmentCode', N'SegmentDefinition', N'SegmentTitle') AND [object_id] = OBJECT_ID(N'[dbo].[SegmentCategories]'))
    SET IDENTITY_INSERT [dbo].[SegmentCategories] ON;
INSERT INTO [dbo].[SegmentCategories] ([ID], [SegmentCode], [SegmentDefinition], [SegmentTitle])
VALUES (29, 98000000, N'', N'Raw Materials (Non Food)'),
(28, 79000000, N'', N'Plumbing/Heating/Ventilation/Air Conditioning'),
(24, 96000000, N'', N'Monetary Assets'),
(26, 64000000, N'', N'Personal Accessories'),
(25, 61000000, N'', N'Music'),
(30, 85000000, N'', N'Safety/Protection - DIY'),
(27, 10000000, N'', N'Pet Care/Food'),
(31, 91000000, N'', N'Safety/Security/Surveillance'),
(38, 80000000, N'', N'Tools/Equipment - Hand'),
(33, 71000000, N'', N'Sports Equipment'),
(34, 62000000, N'', N'Stationery/Office Machinery/Occasion Supplies'),
(35, 92000000, N'', N'Storage/Haulage Containers'),
(36, 60000000, N'', N'Textual/Printed/Reference Materials'),
(37, 84000000, N'', N'Tool Storage/Workshop Aids'),
(39, 82000000, N'', N'Tools/Equipment - Power'),
(40, 86000000, N'', N'Toys/Games'),
(41, 77000000, N'', N'Vehicle'),
(23, 88000000, N'', N'Lubricants'),
(32, 95000000, N'', N'Services/Vending Machines'),
(22, 89000000, N'', N'Live Animals'),
(14, 63000000, N'', N'Footwear'),
(20, 73000000, N'', N'Kitchenware and Tableware'),
(21, 81000000, N'', N'Lawn/Garden Supplies'),
(1, 70000000, N'', N'Arts/Crafts/Needlework'),
(2, 68000000, N'', N'Audio Visual/Photography'),
(4, 83000000, N'', N'Building Products'),
(5, 74000000, N'', N'Camping'),
(6, 47000000, N'', N'Cleaning/Hygiene Products'),
(7, 67000000, N'', N'Clothing'),
(8, 66000000, N'', N'Communications'),
(9, 65000000, N'', N'Computing'),
(3, 53000000, N'', N'Beauty/Personal Care/Hygiene'),
(11, 58000000, N'', N'Cross Segment'),
(12, 78000000, N'', N'Electrical Supplies'),
(13, 50000000, N'', N'Food/Beverage/Tobacco'),
(15, 87000000, N'', N'Fuels/Gases'),
(16, 51000000, N'', N'Healthcare');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'SegmentCode', N'SegmentDefinition', N'SegmentTitle') AND [object_id] = OBJECT_ID(N'[dbo].[SegmentCategories]'))
    SET IDENTITY_INSERT [dbo].[SegmentCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'SegmentCode', N'SegmentDefinition', N'SegmentTitle') AND [object_id] = OBJECT_ID(N'[dbo].[SegmentCategories]'))
    SET IDENTITY_INSERT [dbo].[SegmentCategories] ON;
INSERT INTO [dbo].[SegmentCategories] ([ID], [SegmentCode], [SegmentDefinition], [SegmentTitle])
VALUES (17, 72000000, N'', N'Home Appliances'),
(18, 93000000, N'', N'Horticulture Plants'),
(10, 94000000, N'', N'Crops'),
(19, 75000000, N'', N'Household/Office Furniture/Furnishings');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'SegmentCode', N'SegmentDefinition', N'SegmentTitle') AND [object_id] = OBJECT_ID(N'[dbo].[SegmentCategories]'))
    SET IDENTITY_INSERT [dbo].[SegmentCategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (581, N'United States Minor Outlying Islands'),
(580, N'Northern Mariana Islands'),
(578, N'Norway'),
(574, N'Norfolk Island'),
(570, N'Niue'),
(554, N'New Zealand'),
(562, N'Niger'),
(558, N'Nicaragua'),
(548, N'Vanuatu'),
(540, N'New Caledonia'),
(583, N'Micronesia, Federated States of'),
(566, N'Nigeria'),
(584, N'Marshall Islands'),
(616, N'Poland'),
(586, N'Pakistan'),
(591, N'Panama'),
(598, N'Papua New Guinea'),
(600, N'Paraguay'),
(604, N'Peru'),
(608, N'Philippines'),
(612, N'Pitcairn'),
(535, N'Bonaire, Saint Eustatius, SABA'),
(620, N'Portugal'),
(624, N'Guinea-Bissau'),
(626, N'Timor-Leste'),
(630, N'Puerto Rico'),
(634, N'Qatar'),
(585, N'Palau'),
(534, N'Sint-Maarten (Dutch part)'),
(500, N'Montserrat'),
(531, N'Curacao'),
(434, N'Libyan Arab Jamahiriya'),
(438, N'Liechtenstein'),
(440, N'Lithuania'),
(442, N'Luxembourg'),
(446, N'Macao'),
(450, N'Madagascar'),
(454, N'Malawi');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (458, N'Malaysia'),
(462, N'Maldives'),
(466, N'Mali'),
(470, N'Malta'),
(474, N'Martinique'),
(478, N'Mauritania'),
(480, N'Mauritius'),
(484, N'Mexico'),
(492, N'Monaco'),
(496, N'Mongolia'),
(498, N'Moldova, Republic of'),
(499, N'Montenegro'),
(638, N'Réunion'),
(504, N'Morocco'),
(508, N'Mozambique'),
(512, N'Oman'),
(516, N'Namibia'),
(520, N'Nauru'),
(524, N'Nepal'),
(528, N'Netherlands'),
(533, N'Aruba'),
(642, N'Romania'),
(670, N'Saint Vincent and the Grenadines'),
(646, N'Rwanda'),
(764, N'Thailand'),
(768, N'Togo'),
(772, N'Tokelau'),
(776, N'Tonga'),
(780, N'Trinidad and Tobago'),
(784, N'United Arab Emirates'),
(788, N'Tunisia'),
(792, N'Turkey'),
(795, N'Turkmenistan'),
(796, N'Turks and Caicos Islands'),
(798, N'Tuvalu'),
(800, N'Uganda'),
(804, N'Ukraine'),
(762, N'Tajikistan'),
(807, N'North Macedonia'),
(826, N'United Kingdom'),
(831, N'Guernsey'),
(832, N'Jersey');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (833, N'Isle of Man'),
(834, N'Tanzania, United Republic of'),
(840, N'United States'),
(850, N'Virgin Islands, U.S.'),
(854, N'Burkina Faso'),
(858, N'Uruguay'),
(860, N'Uzbekistan'),
(862, N'Venezuela, Bolivarian Republic of'),
(876, N'Wallis and Futuna'),
(882, N'Samoa'),
(818, N'Egypt'),
(643, N'Russian Federation'),
(760, N'Syrian Arab Republic'),
(752, N'Sweden'),
(652, N'Saint Barthélemy'),
(654, N'Saint Helena'),
(659, N'Saint Kitts and Nevis'),
(660, N'Anguilla'),
(662, N'Saint Lucia'),
(663, N'Saint Martin (French part)'),
(666, N'Saint Pierre and Miquelon'),
(430, N'Liberia'),
(674, N'San Marino'),
(678, N'Sao Tome and Principe'),
(682, N'Saudi Arabia'),
(686, N'Senegal'),
(688, N'Serbia'),
(756, N'Switzerland'),
(690, N'Seychelles'),
(702, N'Singapore'),
(703, N'Slovakia'),
(704, N'Viet Nam'),
(705, N'Slovenia'),
(706, N'Somalia'),
(710, N'South Africa'),
(716, N'Zimbabwe'),
(724, N'Spain'),
(732, N'Western Sahara'),
(736, N'Sudan'),
(740, N'Suriname'),
(744, N'Svalbard and Jan Mayen'),
(748, N'Swaziland');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (694, N'Sierra Leone'),
(428, N'Latvia'),
(398, N'Kazakhstan'),
(422, N'Lebanon'),
(97, N'European Union'),
(100, N'Bulgaria'),
(104, N'Myanmar'),
(108, N'Burundi'),
(112, N'Belarus'),
(116, N'Cambodia'),
(120, N'Cameroon'),
(124, N'Canada'),
(132, N'Cape Verde'),
(136, N'Cayman Islands'),
(140, N'Central African Republic'),
(144, N'Sri Lanka'),
(148, N'Chad'),
(152, N'Chile'),
(156, N'China'),
(158, N'Taiwan, Province of China'),
(162, N'Christmas Island'),
(166, N'Cocos (Keeling) Islands'),
(170, N'Colombia'),
(174, N'Comoros'),
(175, N'Mayotte'),
(178, N'Congo'),
(184, N'Cook Islands'),
(180, N'Congo, the Democratic Republic of the'),
(188, N'Costa Rica'),
(191, N'Croatia'),
(192, N'Cuba'),
(96, N'Brunei Darussalam'),
(92, N'Virgin Islands, British'),
(90, N'Solomon Islands'),
(86, N'British Indian Ocean Territory'),
(887, N'Yemen'),
(1, N'Global Market'),
(4, N'Afghanistan'),
(8, N'Albania'),
(10, N'Antarctica'),
(12, N'Algeria'),
(16, N'American Samoa');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (20, N'Andorra'),
(24, N'Angola'),
(28, N'Antigua and Barbuda'),
(31, N'Azerbaijan'),
(32, N'Argentina'),
(36, N'Australia'),
(196, N'Cyprus'),
(40, N'Austria'),
(48, N'Bahrain'),
(50, N'Bangladesh'),
(51, N'Armenia'),
(52, N'Barbados'),
(56, N'Belgium'),
(60, N'Bermuda'),
(64, N'Bhutan'),
(68, N'Bolivia, Plurinational State of'),
(70, N'Bosnia and Herzegovina'),
(72, N'Botswana'),
(74, N'Bouvet Island'),
(76, N'Brazil'),
(84, N'Belize'),
(44, N'Bahamas'),
(203, N'Czech Republic'),
(204, N'Benin'),
(208, N'Denmark'),
(316, N'Guam'),
(320, N'Guatemala'),
(324, N'Guinea'),
(328, N'Guyana'),
(332, N'Haiti'),
(334, N'Heard Island and McDonald Islands'),
(336, N'Holy See (Vatican City State)'),
(340, N'Honduras'),
(344, N'Hong Kong'),
(348, N'Hungary'),
(352, N'Iceland'),
(356, N'India'),
(360, N'Indonesia'),
(312, N'Guadeloupe'),
(364, N'Iran, Islamic Republic of'),
(372, N'Ireland'),
(376, N'Israel');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (380, N'Italy'),
(384, N'Côte d''Ivoire'),
(388, N'Jamaica'),
(392, N'Japan'),
(400, N'Jordan'),
(404, N'Kenya'),
(408, N'Korea, Democratic People''s Republic of'),
(410, N'Korea, Republic of'),
(414, N'Kuwait'),
(417, N'Kyrgyzstan'),
(418, N'Lao People''s Democratic Republic'),
(368, N'Iraq'),
(426, N'Lesotho'),
(308, N'Grenada'),
(300, N'Greece'),
(231, N'Ethiopia'),
(212, N'Dominica'),
(214, N'Dominican Republic'),
(218, N'Ecuador'),
(222, N'El Salvador'),
(226, N'Equatorial Guinea'),
(232, N'Eritrea'),
(233, N'Estonia'),
(234, N'Faroe Islands'),
(238, N'Falkland Islands (Malvinas)'),
(239, N'South Georgia and the South Sandwich Islands'),
(242, N'Fiji'),
(246, N'Finland'),
(304, N'Greenland'),
(249, N'Metropolitan France'),
(250, N'France'),
(254, N'French Guiana'),
(258, N'French Polynesia'),
(260, N'French Southern Territories'),
(262, N'Djibouti'),
(266, N'Gabon'),
(268, N'Georgia'),
(270, N'Gambia'),
(275, N'Occupied Palestinian Territory'),
(276, N'Germany'),
(288, N'Ghana'),
(292, N'Gibraltar');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (296, N'Kiribati');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (248, N'Åland Islands');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] ON;
INSERT INTO [dbo].[TargetMarkets] ([id], [name])
VALUES (894, N'Zambia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[TargetMarkets]'))
    SET IDENTITY_INSERT [dbo].[TargetMarkets] OFF;
GO

CREATE UNIQUE INDEX [IX_BrandInformations_brandname] ON [dbo].[BrandInformations] ([brandname]);
GO

CREATE UNIQUE INDEX [IX_ClassCategories_ClassCode] ON [dbo].[ClassCategories] ([ClassCode]);
GO

CREATE INDEX [IX_ClassCategories_FamilyCode] ON [dbo].[ClassCategories] ([FamilyCode]);
GO

CREATE INDEX [IX_Companies_country_id] ON [dbo].[Companies] ([country_id]);
GO

CREATE INDEX [IX_Companies_localgovt_id] ON [dbo].[Companies] ([localgovt_id]);
GO

CREATE UNIQUE INDEX [IX_Companies_registrationid] ON [dbo].[Companies] ([registrationid]);
GO

CREATE INDEX [IX_Companies_sectorcategory_id] ON [dbo].[Companies] ([sectorcategory_id]);
GO

CREATE INDEX [IX_Companies_sectortype_id] ON [dbo].[Companies] ([sectortype_id]);
GO

CREATE INDEX [IX_ContactInformations_heardaboutus_id] ON [dbo].[ContactInformations] ([heardaboutus_id]);
GO

CREATE UNIQUE INDEX [IX_ContactInformations_registrationId] ON [dbo].[ContactInformations] ([registrationId]) WHERE [registrationId] IS NOT NULL;
GO

CREATE UNIQUE INDEX [IX_ExternalUnifiedModels_product_id] ON [dbo].[ExternalUnifiedModels] ([product_id]);
GO

CREATE UNIQUE INDEX [IX_FamilyCategories_FamilyCode] ON [dbo].[FamilyCategories] ([FamilyCode]);
GO

CREATE INDEX [IX_FamilyCategories_SegmentCode] ON [dbo].[FamilyCategories] ([SegmentCode]);
GO

CREATE INDEX [IX_GTINRequests_company_id] ON [dbo].[GTINRequests] ([company_id]);
GO

CREATE INDEX [IX_GTINRequests_gtinfee_id] ON [dbo].[GTINRequests] ([gtinfee_id]);
GO

CREATE UNIQUE INDEX [IX_ImageBanks_registrationid] ON [dbo].[ImageBanks] ([registrationid]);
GO

CREATE INDEX [IX_LocalGovts_state_id] ON [dbo].[LocalGovts] ([state_id]);
GO

CREATE UNIQUE INDEX [IX_PharmaceuticalInformations_ProductID] ON [dbo].[PharmaceuticalInformations] ([ProductID]);
GO

CREATE INDEX [IX_Products_brandinformation_id] ON [dbo].[Products] ([brandinformation_id]);
GO

CREATE INDEX [IX_Products_brickcategory_id] ON [dbo].[Products] ([brickcategory_id]);
GO

CREATE UNIQUE INDEX [IX_Products_gtin] ON [dbo].[Products] ([gtin]);
GO

CREATE INDEX [IX_Products_netcontent_id] ON [dbo].[Products] ([netcontent_id]);
GO

CREATE INDEX [IX_Products_packaginglevel_id] ON [dbo].[Products] ([packaginglevel_id]);
GO

CREATE INDEX [IX_Products_packagingtype_id] ON [dbo].[Products] ([packagingtype_id]);
GO

CREATE INDEX [IX_ProductTargetMarkets_product_id] ON [dbo].[ProductTargetMarkets] ([product_id]);
GO

CREATE INDEX [IX_ProductTargetMarkets_targetmarket_id] ON [dbo].[ProductTargetMarkets] ([targetmarket_id]);
GO

CREATE UNIQUE INDEX [IX_SegmentCategories_SegmentCode] ON [dbo].[SegmentCategories] ([SegmentCode]);
GO

CREATE INDEX [IX_States_country_id] ON [dbo].[States] ([country_id]);
GO

CREATE INDEX [IX_Users_Companiesid] ON [dbo].[Users] ([Companiesid]);
GO

CREATE INDEX [IX_Users_Rolesid] ON [dbo].[Users] ([Rolesid]);
GO

CREATE INDEX [IX_UserValidationTokens_Userid] ON [dbo].[UserValidationTokens] ([Userid]);
GO

INSERT INTO [__opensourcemigrationhistory] ([MigrationId], [ProductVersion])
VALUES (N'20230410132139_First_Time_Migration', N'5.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] ON;
INSERT INTO [dbo].[Countries] ([id], [name])
VALUES (1, N'Afghanistan'),
(160, N'Niger'),
(161, N'Nigeria'),
(162, N'Niue'),
(163, N'Norfolk Island'),
(164, N'Northern Mariana Islands'),
(165, N'Norway'),
(166, N'Oman'),
(167, N'Pakistan'),
(168, N'Palau'),
(169, N'Palestinian Territory Occupied'),
(170, N'Panama'),
(171, N'Papua new Guinea'),
(172, N'Paraguay'),
(173, N'Peru'),
(174, N'Philippines'),
(175, N'Pitcairn Island'),
(176, N'Poland'),
(177, N'Portugal'),
(178, N'Puerto Rico'),
(179, N'Qatar'),
(180, N'Reunion'),
(181, N'Romania'),
(182, N'Russia'),
(183, N'Rwanda'),
(184, N'Saint Helena'),
(185, N'Saint Kitts And Nevis'),
(186, N'Saint Lucia'),
(159, N'Nicaragua'),
(158, N'New Zealand'),
(157, N'New Caledonia'),
(156, N'Netherlands The'),
(128, N'Macau S.A.R.'),
(129, N'Macedonia'),
(130, N'Madagascar'),
(131, N'Malawi'),
(132, N'Malaysia'),
(133, N'Maldives'),
(134, N'Mali'),
(135, N'Malta'),
(136, N'Man (Isle of)'),
(137, N'Marshall Islands');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] ON;
INSERT INTO [dbo].[Countries] ([id], [name])
VALUES (138, N'Martinique'),
(139, N'Mauritania'),
(140, N'Mauritius'),
(187, N'Saint Pierre and Miquelon'),
(141, N'Mayotte'),
(143, N'Micronesia'),
(144, N'Moldova'),
(145, N'Monaco'),
(146, N'Mongolia'),
(147, N'Montenegro'),
(148, N'Montserrat'),
(149, N'Morocco'),
(150, N'Mozambique'),
(151, N'Myanmar'),
(152, N'Namibia'),
(153, N'Nauru'),
(154, N'Nepal'),
(155, N'Bonaire, Sint Eustatius and Saba'),
(142, N'Mexico'),
(127, N'Luxembourg'),
(188, N'Saint Vincent And The Grenadines'),
(190, N'Saint-Martin (French part)'),
(224, N'Tunisia'),
(225, N'Turkey'),
(226, N'Turkmenistan'),
(227, N'Turks And Caicos Islands'),
(228, N'Tuvalu'),
(229, N'Uganda'),
(230, N'Ukraine'),
(231, N'United Arab Emirates'),
(232, N'United Kingdom'),
(233, N'United States'),
(234, N'United States Minor Outlying Islands'),
(235, N'Uruguay'),
(236, N'Uzbekistan'),
(237, N'Vanuatu'),
(238, N'Vatican City State (Holy See)'),
(239, N'Venezuela'),
(240, N'Vietnam'),
(241, N'Virgin Islands (British)'),
(242, N'Virgin Islands (US)'),
(243, N'Wallis And Futuna Islands');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] ON;
INSERT INTO [dbo].[Countries] ([id], [name])
VALUES (244, N'Western Sahara'),
(245, N'Yemen'),
(246, N'Zambia'),
(247, N'Zimbabwe'),
(248, N'Kosovo'),
(249, N'Curaçao'),
(250, N'Sint Maarten (Dutch part)'),
(223, N'Trinidad And Tobago'),
(222, N'Tonga'),
(221, N'Tokelau'),
(220, N'Togo'),
(191, N'Samoa'),
(192, N'San Marino'),
(193, N'Sao Tome and Principe'),
(194, N'Saudi Arabia'),
(195, N'Senegal'),
(196, N'Serbia'),
(197, N'Seychelles'),
(198, N'Sierra Leone'),
(199, N'Singapore'),
(200, N'Slovakia'),
(201, N'Slovenia'),
(202, N'Solomon Islands'),
(204, N'South Africa'),
(189, N'Saint-Barthelemy'),
(205, N'South Georgia'),
(207, N'Spain'),
(208, N'Sri Lanka'),
(209, N'Sudan'),
(210, N'Suriname'),
(211, N'Svalbard And Jan Mayen Islands'),
(212, N'Swaziland'),
(213, N'Sweden'),
(214, N'Switzerland'),
(215, N'Syria'),
(216, N'Taiwan'),
(217, N'Tajikistan'),
(218, N'Tanzania'),
(219, N'Thailand'),
(206, N'South Sudan'),
(126, N'Lithuania'),
(203, N'Somalia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] ON;
INSERT INTO [dbo].[Countries] ([id], [name])
VALUES (124, N'Libya'),
(33, N'Brunei'),
(34, N'Bulgaria'),
(35, N'Burkina Faso'),
(36, N'Burundi'),
(37, N'Cambodia'),
(38, N'Cameroon'),
(39, N'Canada'),
(40, N'Cape Verde'),
(41, N'Cayman Islands'),
(42, N'Central African Republic'),
(43, N'Chad'),
(44, N'Chile'),
(45, N'China'),
(46, N'Christmas Island'),
(47, N'Cocos (Keeling) Islands'),
(48, N'Colombia'),
(49, N'Comoros'),
(50, N'Congo'),
(51, N'Congo The Democratic Republic Of The'),
(52, N'Cook Islands'),
(53, N'Costa Rica'),
(54, N'Cote D''Ivoire (Ivory Coast)'),
(55, N'Croatia (Hrvatska)'),
(57, N'Cyprus'),
(58, N'Czech Republic'),
(59, N'Denmark'),
(60, N'Djibouti'),
(32, N'British Indian Ocean Territory'),
(61, N'Dominica'),
(31, N'Brazil'),
(29, N'Botswana'),
(2, N'Aland Islands'),
(3, N'Albania'),
(4, N'Algeria'),
(5, N'American Samoa'),
(6, N'Andorra'),
(7, N'Angola'),
(8, N'Anguilla'),
(9, N'Antarctica'),
(10, N'Antigua And Barbuda'),
(11, N'Argentina');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] ON;
INSERT INTO [dbo].[Countries] ([id], [name])
VALUES (12, N'Armenia'),
(13, N'Aruba'),
(14, N'Australia'),
(15, N'Austria'),
(16, N'Azerbaijan'),
(17, N'Bahamas The'),
(18, N'Bahrain'),
(19, N'Bangladesh'),
(20, N'Barbados'),
(21, N'Belarus'),
(22, N'Belgium'),
(23, N'Belize'),
(24, N'Benin'),
(25, N'Bermuda'),
(26, N'Bhutan'),
(27, N'Bolivia'),
(28, N'Bosnia and Herzegovina'),
(30, N'Bouvet Island'),
(62, N'Dominican Republic'),
(56, N'Cuba'),
(64, N'Ecuador'),
(96, N'Heard Island and McDonald Islands'),
(97, N'Honduras'),
(98, N'Hong Kong S.A.R.'),
(63, N'East Timor'),
(100, N'Iceland'),
(101, N'India'),
(102, N'Indonesia'),
(103, N'Iran'),
(104, N'Iraq'),
(105, N'Ireland'),
(106, N'Israel'),
(107, N'Italy'),
(108, N'Jamaica'),
(95, N'Haiti'),
(109, N'Japan'),
(111, N'Jordan'),
(112, N'Kazakhstan'),
(113, N'Kenya'),
(114, N'Kiribati'),
(115, N'Korea North'),
(116, N'Korea South');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] ON;
INSERT INTO [dbo].[Countries] ([id], [name])
VALUES (117, N'Kuwait'),
(118, N'Kyrgyzstan'),
(119, N'Laos'),
(120, N'Latvia'),
(121, N'Lebanon'),
(122, N'Lesotho'),
(123, N'Liberia'),
(110, N'Jersey'),
(94, N'Guyana'),
(99, N'Hungary'),
(92, N'Guinea'),
(65, N'Egypt'),
(66, N'El Salvador'),
(67, N'Equatorial Guinea'),
(68, N'Eritrea'),
(69, N'Estonia'),
(70, N'Ethiopia'),
(71, N'Falkland Islands'),
(93, N'Guinea-Bissau'),
(73, N'Fiji Islands'),
(74, N'Finland'),
(75, N'France'),
(76, N'French Guiana'),
(77, N'French Polynesia'),
(72, N'Faroe Islands'),
(79, N'Gabon'),
(78, N'French Southern Territories'),
(90, N'Guatemala'),
(89, N'Guam'),
(88, N'Guadeloupe'),
(87, N'Grenada'),
(86, N'Greenland'),
(91, N'Guernsey and Alderney'),
(84, N'Gibraltar'),
(85, N'Greece'),
(80, N'Gambia The'),
(81, N'Georgia'),
(125, N'Liechtenstein'),
(83, N'Ghana'),
(82, N'Germany');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[Countries]'))
    SET IDENTITY_INSERT [dbo].[Countries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'AdditionalFee', N'Description', N'NumberOfGtins', N'Price', N'RenewalFee') AND [object_id] = OBJECT_ID(N'[dbo].[GTINFees]'))
    SET IDENTITY_INSERT [dbo].[GTINFees] ON;
INSERT INTO [dbo].[GTINFees] ([ID], [AdditionalFee], [Description], [NumberOfGtins], [Price], [RenewalFee])
VALUES (32, 260000.0E0, N'401-1000', 1000, 312500.0E0, 250000.0E0),
(31, 235000.0E0, N'301-400', 400, 247500.0E0, 225000.0E0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'AdditionalFee', N'Description', N'NumberOfGtins', N'Price', N'RenewalFee') AND [object_id] = OBJECT_ID(N'[dbo].[GTINFees]'))
    SET IDENTITY_INSERT [dbo].[GTINFees] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'AdditionalFee', N'Description', N'NumberOfGtins', N'Price', N'RenewalFee') AND [object_id] = OBJECT_ID(N'[dbo].[GTINFees]'))
    SET IDENTITY_INSERT [dbo].[GTINFees] ON;
INSERT INTO [dbo].[GTINFees] ([ID], [AdditionalFee], [Description], [NumberOfGtins], [Price], [RenewalFee])
VALUES (30, 210000.0E0, N'201-300', 300, 222500.0E0, 200000.0E0),
(29, 185000.0E0, N'151-200', 200, 197500.0E0, 175000.0E0),
(19, 20000.0E0, N'01-10', 10, 32500.0E0, 10000.0E0),
(27, 135000.0E0, N'81-100', 100, 147500.0E0, 125000.0E0),
(26, 110000.0E0, N'71-80', 80, 122500.0E0, 100000.0E0),
(25, 85000.0E0, N'61-70', 70, 97500.0E0, 75000.0E0),
(24, 65000.0E0, N'51-60', 60, 77500.0E0, 55000.0E0),
(23, 55000.0E0, N'41-50', 50, 67500.0E0, 45000.0E0),
(22, 45000.0E0, N'31-40', 40, 57500.0E0, 35000.0E0),
(21, 35000.0E0, N'21-30', 30, 47500.0E0, 25000.0E0),
(20, 25000.0E0, N'11-20', 20, 37500.0E0, 15000.0E0),
(28, 160000.0E0, N'101-150', 150, 172500.0E0, 150000.0E0),
(16, 0.0E0, N'2000 plus', 2000, 0.0E0, 400000.0E0),
(14, 282000.0E0, N'301-400', 400, 297000.0E0, 270000.0E0),
(15, 312000.0E0, N'401-1000', 1000, 375000.0E0, 300000.0E0),
(2, 24000.0E0, N'6-10', 10, 39000.0E0, 10000.0E0),
(3, 30000.0E0, N'11-20', 20, 45000.0E0, 15000.0E0),
(4, 42000.0E0, N'21-30', 30, 57000.0E0, 25000.0E0),
(5, 54000.0E0, N'31-40', 40, 69000.0E0, 42000.0E0),
(6, 66000.0E0, N'41-50', 50, 81000.0E0, 54000.0E0),
(1, 15000.0E0, N'1-5', 5, 33000.0E0, 10000.0E0),
(8, 102000.0E0, N'61-70', 70, 117000.0E0, 90000.0E0),
(9, 13200.0E0, N'71-80', 80, 147000.0E0, 120000.0E0),
(10, 162000.0E0, N'81-100', 100, 177000.0E0, 150000.0E0),
(11, 192000.0E0, N'101-150', 150, 207000.0E0, 180000.0E0),
(12, 222000.0E0, N'151-200', 200, 237000.0E0, 210000.0E0),
(7, 78000.0E0, N'51-60', 60, 93000.0E0, 66000.0E0),
(13, 252000.0E0, N'201-300', 300, 267000.0E0, 240000.0E0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'AdditionalFee', N'Description', N'NumberOfGtins', N'Price', N'RenewalFee') AND [object_id] = OBJECT_ID(N'[dbo].[GTINFees]'))
    SET IDENTITY_INSERT [dbo].[GTINFees] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] ON;
INSERT INTO [dbo].[LocalGovts] ([id], [name], [state_id])
VALUES (170, N'Panama', 0),
(169, N'Palestinian Territory Occupied', 0),
(168, N'Palau', 0),
(167, N'Pakistan', 0),
(166, N'Oman', 0),
(163, N'Norfolk Island', 0),
(164, N'Northern Mariana Islands', 0),
(162, N'Niue', 0),
(161, N'Nigeria', 0),
(160, N'Niger', 0),
(171, N'Papua new Guinea', 0),
(165, N'Norway', 0),
(172, N'Paraguay', 0),
(180, N'Reunion', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] ON;
INSERT INTO [dbo].[LocalGovts] ([id], [name], [state_id])
VALUES (174, N'Philippines', 0),
(175, N'Pitcairn Island', 0),
(176, N'Poland', 0),
(177, N'Portugal', 0),
(178, N'Puerto Rico', 0),
(179, N'Qatar', 0),
(159, N'Nicaragua', 0),
(181, N'Romania', 0),
(182, N'Russia', 0),
(183, N'Rwanda', 0),
(184, N'Saint Helena', 0),
(185, N'Saint Kitts And Nevis', 0),
(186, N'Saint Lucia', 0),
(173, N'Peru', 0),
(158, N'New Zealand', 0),
(151, N'Myanmar', 0),
(156, N'Netherlands The', 0),
(128, N'Macau S.A.R.', 0),
(129, N'Macedonia', 0),
(130, N'Madagascar', 0),
(131, N'Malawi', 0),
(132, N'Malaysia', 0),
(133, N'Maldives', 0),
(134, N'Mali', 0),
(135, N'Malta', 0),
(136, N'Man (Isle of)', 0),
(137, N'Marshall Islands', 0),
(138, N'Martinique', 0),
(139, N'Mauritania', 0),
(140, N'Mauritius', 0),
(157, N'New Caledonia', 0),
(141, N'Mayotte', 0),
(143, N'Micronesia', 0),
(144, N'Moldova', 0),
(145, N'Monaco', 0),
(146, N'Mongolia', 0),
(147, N'Montenegro', 0),
(148, N'Montserrat', 0),
(149, N'Morocco', 0),
(150, N'Mozambique', 0),
(187, N'Saint Pierre and Miquelon', 0),
(152, N'Namibia', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] ON;
INSERT INTO [dbo].[LocalGovts] ([id], [name], [state_id])
VALUES (153, N'Nauru', 0),
(154, N'Nepal', 0),
(155, N'Bonaire, Sint Eustatius and Saba', 0),
(142, N'Mexico', 0),
(188, N'Saint Vincent And The Grenadines', 0),
(196, N'Serbia', 0),
(190, N'Saint-Martin (French part)', 0),
(224, N'Tunisia', 0),
(225, N'Turkey', 0),
(226, N'Turkmenistan', 0),
(227, N'Turks And Caicos Islands', 0),
(228, N'Tuvalu', 0),
(229, N'Uganda', 0),
(230, N'Ukraine', 0),
(231, N'United Arab Emirates', 0),
(232, N'United Kingdom', 0),
(233, N'United States', 0),
(234, N'United States Minor Outlying Islands', 0),
(235, N'Uruguay', 0),
(236, N'Uzbekistan', 0),
(223, N'Trinidad And Tobago', 0),
(237, N'Vanuatu', 0),
(239, N'Venezuela', 0),
(240, N'Vietnam', 0),
(241, N'Virgin Islands (British)', 0),
(242, N'Virgin Islands (US)', 0),
(243, N'Wallis And Futuna Islands', 0),
(244, N'Western Sahara', 0),
(245, N'Yemen', 0),
(246, N'Zambia', 0),
(247, N'Zimbabwe', 0),
(248, N'Kosovo', 0),
(249, N'Curaçao', 0),
(250, N'Sint Maarten (Dutch part)', 0),
(127, N'Luxembourg', 0),
(238, N'Vatican City State (Holy See)', 0),
(189, N'Saint-Barthelemy', 0),
(222, N'Tonga', 0),
(220, N'Togo', 0),
(191, N'Samoa', 0),
(192, N'San Marino', 0),
(193, N'Sao Tome and Principe', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] ON;
INSERT INTO [dbo].[LocalGovts] ([id], [name], [state_id])
VALUES (194, N'Saudi Arabia', 0),
(195, N'Senegal', 0),
(197, N'Seychelles', 0),
(198, N'Sierra Leone', 0),
(199, N'Singapore', 0),
(200, N'Slovakia', 0),
(201, N'Slovenia', 0),
(202, N'Solomon Islands', 0),
(203, N'Somalia', 0),
(204, N'South Africa', 0),
(221, N'Tokelau', 0),
(205, N'South Georgia', 0),
(207, N'Spain', 0),
(208, N'Sri Lanka', 0),
(209, N'Sudan', 0),
(210, N'Suriname', 0),
(211, N'Svalbard And Jan Mayen Islands', 0),
(212, N'Swaziland', 0),
(213, N'Sweden', 0),
(214, N'Switzerland', 0),
(215, N'Syria', 0),
(216, N'Taiwan', 0),
(217, N'Tajikistan', 0),
(218, N'Tanzania', 0),
(219, N'Thailand', 0),
(206, N'South Sudan', 0),
(126, N'Lithuania', 0),
(110, N'Jersey', 0),
(124, N'Libya', 0),
(33, N'Brunei', 0),
(34, N'Bulgaria', 0),
(35, N'Burkina Faso', 0),
(36, N'Burundi', 0),
(37, N'Cambodia', 0),
(38, N'Cameroon', 0),
(39, N'Canada', 0),
(40, N'Cape Verde', 0),
(41, N'Cayman Islands', 0),
(42, N'Central African Republic', 0),
(43, N'Chad', 0),
(44, N'Chile', 0),
(45, N'China', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] ON;
INSERT INTO [dbo].[LocalGovts] ([id], [name], [state_id])
VALUES (46, N'Christmas Island', 0),
(47, N'Cocos (Keeling) Islands', 0),
(48, N'Colombia', 0),
(49, N'Comoros', 0),
(50, N'Congo', 0),
(51, N'Congo The Democratic Republic Of The', 0),
(52, N'Cook Islands', 0),
(53, N'Costa Rica', 0),
(54, N'Cote D''Ivoire (Ivory Coast)', 0),
(55, N'Croatia (Hrvatska)', 0),
(56, N'Cuba', 0),
(57, N'Cyprus', 0),
(58, N'Czech Republic', 0),
(59, N'Denmark', 0),
(32, N'British Indian Ocean Territory', 0),
(31, N'Brazil', 0),
(30, N'Bouvet Island', 0),
(29, N'Botswana', 0),
(125, N'Liechtenstein', 0),
(2, N'Aland Islands', 0),
(3, N'Albania', 0),
(4, N'Algeria', 0),
(5, N'American Samoa', 0),
(6, N'Andorra', 0),
(7, N'Angola', 0),
(8, N'Anguilla', 0),
(9, N'Antarctica', 0),
(10, N'Antigua And Barbuda', 0),
(11, N'Argentina', 0),
(12, N'Armenia', 0),
(13, N'Aruba', 0),
(60, N'Djibouti', 0),
(14, N'Australia', 0),
(16, N'Azerbaijan', 0),
(17, N'Bahamas The', 0),
(18, N'Bahrain', 0),
(19, N'Bangladesh', 0),
(20, N'Barbados', 0),
(21, N'Belarus', 0),
(22, N'Belgium', 0),
(23, N'Belize', 0),
(24, N'Benin', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] ON;
INSERT INTO [dbo].[LocalGovts] ([id], [name], [state_id])
VALUES (25, N'Bermuda', 0),
(26, N'Bhutan', 0),
(27, N'Bolivia', 0),
(28, N'Bosnia and Herzegovina', 0),
(15, N'Austria', 0),
(61, N'Dominica', 0),
(1, N'Afghanistan', 0),
(63, N'East Timor', 0),
(96, N'Heard Island and McDonald Islands', 0),
(97, N'Honduras', 0),
(98, N'Hong Kong S.A.R.', 0),
(99, N'Hungary', 0),
(100, N'Iceland', 0),
(101, N'India', 0),
(102, N'Indonesia', 0),
(103, N'Iran', 0),
(104, N'Iraq', 0),
(105, N'Ireland', 0),
(106, N'Israel', 0),
(108, N'Jamaica', 0),
(109, N'Japan', 0),
(111, N'Jordan', 0),
(112, N'Kazakhstan', 0),
(113, N'Kenya', 0),
(114, N'Kiribati', 0),
(115, N'Korea North', 0),
(116, N'Korea South', 0),
(117, N'Kuwait', 0),
(118, N'Kyrgyzstan', 0),
(119, N'Laos', 0),
(120, N'Latvia', 0),
(121, N'Lebanon', 0),
(122, N'Lesotho', 0),
(123, N'Liberia', 0),
(62, N'Dominican Republic', 0),
(95, N'Haiti', 0),
(94, N'Guyana', 0),
(107, N'Italy', 0),
(92, N'Guinea', 0),
(64, N'Ecuador', 0),
(65, N'Egypt', 0),
(93, N'Guinea-Bissau', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] ON;
INSERT INTO [dbo].[LocalGovts] ([id], [name], [state_id])
VALUES (67, N'Equatorial Guinea', 0),
(68, N'Eritrea', 0),
(69, N'Estonia', 0),
(70, N'Ethiopia', 0),
(71, N'Falkland Islands', 0),
(72, N'Faroe Islands', 0),
(73, N'Fiji Islands', 0),
(74, N'Finland', 0),
(75, N'France', 0),
(76, N'French Guiana', 0),
(77, N'French Polynesia', 0),
(66, N'El Salvador', 0),
(90, N'Guatemala', 0),
(89, N'Guam', 0),
(88, N'Guadeloupe', 0),
(87, N'Grenada', 0),
(78, N'French Southern Territories', 0),
(85, N'Greece', 0),
(84, N'Gibraltar', 0),
(86, N'Greenland', 0),
(82, N'Germany', 0),
(81, N'Georgia', 0),
(80, N'Gambia The', 0),
(91, N'Guernsey and Alderney', 0),
(79, N'Gabon', 0),
(83, N'Ghana', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'name', N'state_id') AND [object_id] = OBJECT_ID(N'[dbo].[LocalGovts]'))
    SET IDENTITY_INSERT [dbo].[LocalGovts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] ON;
INSERT INTO [dbo].[States] ([id], [country_id], [name])
VALUES (169, 0, N'Palestinian Territory Occupied'),
(168, 0, N'Palau'),
(167, 0, N'Pakistan'),
(166, 0, N'Oman'),
(165, 0, N'Norway'),
(185, 0, N'Saint Kitts And Nevis'),
(163, 0, N'Norfolk Island'),
(162, 0, N'Niue'),
(161, 0, N'Nigeria'),
(160, 0, N'Niger'),
(170, 0, N'Panama'),
(164, 0, N'Northern Mariana Islands'),
(171, 0, N'Papua new Guinea'),
(178, 0, N'Puerto Rico'),
(173, 0, N'Peru'),
(174, 0, N'Philippines');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] ON;
INSERT INTO [dbo].[States] ([id], [country_id], [name])
VALUES (175, 0, N'Pitcairn Island'),
(176, 0, N'Poland'),
(177, 0, N'Portugal'),
(179, 0, N'Qatar'),
(180, 0, N'Reunion'),
(181, 0, N'Romania'),
(182, 0, N'Russia'),
(183, 0, N'Rwanda'),
(184, 0, N'Saint Helena'),
(159, 0, N'Nicaragua'),
(172, 0, N'Paraguay'),
(158, 0, N'New Zealand'),
(128, 0, N'Macau S.A.R.'),
(156, 0, N'Netherlands The'),
(127, 0, N'Luxembourg'),
(129, 0, N'Macedonia'),
(130, 0, N'Madagascar'),
(131, 0, N'Malawi'),
(132, 0, N'Malaysia'),
(133, 0, N'Maldives'),
(134, 0, N'Mali'),
(135, 0, N'Malta'),
(136, 0, N'Man (Isle of)'),
(137, 0, N'Marshall Islands'),
(138, 0, N'Martinique'),
(139, 0, N'Mauritania'),
(140, 0, N'Mauritius'),
(157, 0, N'New Caledonia'),
(141, 0, N'Mayotte'),
(143, 0, N'Micronesia'),
(144, 0, N'Moldova'),
(145, 0, N'Monaco'),
(146, 0, N'Mongolia'),
(147, 0, N'Montenegro'),
(148, 0, N'Montserrat'),
(149, 0, N'Morocco'),
(150, 0, N'Mozambique'),
(151, 0, N'Myanmar'),
(152, 0, N'Namibia'),
(153, 0, N'Nauru'),
(154, 0, N'Nepal'),
(155, 0, N'Bonaire, Sint Eustatius and Saba');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] ON;
INSERT INTO [dbo].[States] ([id], [country_id], [name])
VALUES (142, 0, N'Mexico'),
(186, 0, N'Saint Lucia'),
(216, 0, N'Taiwan'),
(188, 0, N'Saint Vincent And The Grenadines'),
(222, 0, N'Tonga'),
(223, 0, N'Trinidad And Tobago'),
(224, 0, N'Tunisia'),
(225, 0, N'Turkey'),
(226, 0, N'Turkmenistan'),
(227, 0, N'Turks And Caicos Islands'),
(228, 0, N'Tuvalu'),
(229, 0, N'Uganda'),
(230, 0, N'Ukraine'),
(231, 0, N'United Arab Emirates'),
(232, 0, N'United Kingdom'),
(233, 0, N'United States'),
(234, 0, N'United States Minor Outlying Islands'),
(221, 0, N'Tokelau'),
(235, 0, N'Uruguay'),
(237, 0, N'Vanuatu'),
(238, 0, N'Vatican City State (Holy See)'),
(239, 0, N'Venezuela'),
(240, 0, N'Vietnam'),
(241, 0, N'Virgin Islands (British)'),
(242, 0, N'Virgin Islands (US)'),
(243, 0, N'Wallis And Futuna Islands'),
(244, 0, N'Western Sahara'),
(245, 0, N'Yemen'),
(246, 0, N'Zambia'),
(247, 0, N'Zimbabwe'),
(126, 0, N'Lithuania'),
(248, 0, N'Kosovo'),
(236, 0, N'Uzbekistan'),
(187, 0, N'Saint Pierre and Miquelon'),
(220, 0, N'Togo'),
(218, 0, N'Tanzania'),
(189, 0, N'Saint-Barthelemy'),
(190, 0, N'Saint-Martin (French part)'),
(191, 0, N'Samoa'),
(192, 0, N'San Marino'),
(193, 0, N'Sao Tome and Principe'),
(194, 0, N'Saudi Arabia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] ON;
INSERT INTO [dbo].[States] ([id], [country_id], [name])
VALUES (195, 0, N'Senegal'),
(196, 0, N'Serbia'),
(197, 0, N'Seychelles'),
(198, 0, N'Sierra Leone'),
(199, 0, N'Singapore'),
(200, 0, N'Slovakia'),
(201, 0, N'Slovenia'),
(219, 0, N'Thailand'),
(202, 0, N'Solomon Islands'),
(204, 0, N'South Africa'),
(205, 0, N'South Georgia'),
(206, 0, N'South Sudan'),
(207, 0, N'Spain'),
(208, 0, N'Sri Lanka'),
(209, 0, N'Sudan'),
(210, 0, N'Suriname'),
(211, 0, N'Svalbard And Jan Mayen Islands'),
(212, 0, N'Swaziland'),
(213, 0, N'Sweden'),
(214, 0, N'Switzerland'),
(215, 0, N'Syria'),
(217, 0, N'Tajikistan'),
(203, 0, N'Somalia'),
(125, 0, N'Liechtenstein'),
(63, 0, N'East Timor'),
(123, 0, N'Liberia'),
(32, 0, N'British Indian Ocean Territory'),
(33, 0, N'Brunei'),
(34, 0, N'Bulgaria'),
(35, 0, N'Burkina Faso'),
(36, 0, N'Burundi'),
(37, 0, N'Cambodia'),
(38, 0, N'Cameroon'),
(39, 0, N'Canada'),
(40, 0, N'Cape Verde'),
(41, 0, N'Cayman Islands'),
(42, 0, N'Central African Republic'),
(43, 0, N'Chad'),
(44, 0, N'Chile'),
(45, 0, N'China'),
(46, 0, N'Christmas Island'),
(47, 0, N'Cocos (Keeling) Islands');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] ON;
INSERT INTO [dbo].[States] ([id], [country_id], [name])
VALUES (48, 0, N'Colombia'),
(49, 0, N'Comoros'),
(50, 0, N'Congo'),
(51, 0, N'Congo The Democratic Republic Of The'),
(52, 0, N'Cook Islands'),
(53, 0, N'Costa Rica'),
(54, 0, N'Cote D''Ivoire (Ivory Coast)'),
(55, 0, N'Croatia (Hrvatska)'),
(56, 0, N'Cuba'),
(57, 0, N'Cyprus'),
(58, 0, N'Czech Republic'),
(31, 0, N'Brazil'),
(30, 0, N'Bouvet Island'),
(29, 0, N'Botswana'),
(28, 0, N'Bosnia and Herzegovina'),
(249, 0, N'Curaçao'),
(1, 0, N'Afghanistan'),
(2, 0, N'Aland Islands'),
(3, 0, N'Albania'),
(4, 0, N'Algeria'),
(5, 0, N'American Samoa'),
(6, 0, N'Andorra'),
(7, 0, N'Angola'),
(8, 0, N'Anguilla'),
(9, 0, N'Antarctica'),
(10, 0, N'Antigua And Barbuda'),
(11, 0, N'Argentina'),
(12, 0, N'Armenia'),
(59, 0, N'Denmark'),
(13, 0, N'Aruba'),
(15, 0, N'Austria'),
(16, 0, N'Azerbaijan'),
(17, 0, N'Bahamas The'),
(18, 0, N'Bahrain'),
(19, 0, N'Bangladesh'),
(20, 0, N'Barbados'),
(21, 0, N'Belarus'),
(22, 0, N'Belgium'),
(23, 0, N'Belize'),
(24, 0, N'Benin'),
(25, 0, N'Bermuda'),
(26, 0, N'Bhutan');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] ON;
INSERT INTO [dbo].[States] ([id], [country_id], [name])
VALUES (27, 0, N'Bolivia'),
(14, 0, N'Australia'),
(124, 0, N'Libya'),
(60, 0, N'Djibouti'),
(62, 0, N'Dominican Republic'),
(96, 0, N'Heard Island and McDonald Islands'),
(97, 0, N'Honduras'),
(98, 0, N'Hong Kong S.A.R.'),
(99, 0, N'Hungary'),
(100, 0, N'Iceland'),
(101, 0, N'India'),
(102, 0, N'Indonesia'),
(103, 0, N'Iran'),
(104, 0, N'Iraq'),
(105, 0, N'Ireland'),
(106, 0, N'Israel'),
(107, 0, N'Italy'),
(108, 0, N'Jamaica'),
(109, 0, N'Japan'),
(110, 0, N'Jersey'),
(111, 0, N'Jordan'),
(112, 0, N'Kazakhstan'),
(113, 0, N'Kenya'),
(114, 0, N'Kiribati'),
(115, 0, N'Korea North'),
(116, 0, N'Korea South'),
(117, 0, N'Kuwait'),
(118, 0, N'Kyrgyzstan'),
(119, 0, N'Laos'),
(120, 0, N'Latvia'),
(121, 0, N'Lebanon'),
(122, 0, N'Lesotho'),
(95, 0, N'Haiti'),
(94, 0, N'Guyana'),
(93, 0, N'Guinea-Bissau'),
(92, 0, N'Guinea'),
(64, 0, N'Ecuador'),
(65, 0, N'Egypt'),
(66, 0, N'El Salvador'),
(67, 0, N'Equatorial Guinea'),
(68, 0, N'Eritrea'),
(69, 0, N'Estonia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] ON;
INSERT INTO [dbo].[States] ([id], [country_id], [name])
VALUES (70, 0, N'Ethiopia'),
(71, 0, N'Falkland Islands'),
(72, 0, N'Faroe Islands'),
(73, 0, N'Fiji Islands'),
(74, 0, N'Finland'),
(75, 0, N'France'),
(76, 0, N'French Guiana'),
(61, 0, N'Dominica'),
(77, 0, N'French Polynesia'),
(79, 0, N'Gabon'),
(80, 0, N'Gambia The'),
(81, 0, N'Georgia'),
(82, 0, N'Germany'),
(83, 0, N'Ghana'),
(84, 0, N'Gibraltar'),
(85, 0, N'Greece'),
(86, 0, N'Greenland'),
(87, 0, N'Grenada'),
(88, 0, N'Guadeloupe'),
(89, 0, N'Guam'),
(90, 0, N'Guatemala'),
(91, 0, N'Guernsey and Alderney'),
(78, 0, N'French Southern Territories'),
(250, 0, N'Sint Maarten (Dutch part)');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'country_id', N'name') AND [object_id] = OBJECT_ID(N'[dbo].[States]'))
    SET IDENTITY_INSERT [dbo].[States] OFF;
GO

ALTER TABLE [dbo].[GTINRequests] ADD CONSTRAINT [FK_GTINRequests_Companies_company_id] FOREIGN KEY ([company_id]) REFERENCES [dbo].[Companies] ([id]) ON DELETE CASCADE;
GO

ALTER TABLE [dbo].[Users] ADD CONSTRAINT [FK_Users_Companies_Companiesid] FOREIGN KEY ([Companiesid]) REFERENCES [dbo].[Companies] ([id]) ON DELETE NO ACTION;
GO

INSERT INTO [__opensourcemigrationhistory] ([MigrationId], [ProductVersion])
VALUES (N'20230410132139_First_Time_Migration', N'5.0.10');
GO

INSERT INTO [__opensourcemigrationhistory] ([MigrationId], [ProductVersion])
VALUES (N'20230410143129_Seed_Record_countries_states_lga_gtinfee', N'5.0.10');
GO

COMMIT;
GO

