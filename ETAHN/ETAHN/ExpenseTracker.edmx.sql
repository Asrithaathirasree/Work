
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/31/2017 02:27:31
-- Generated from EDMX file: C:\Users\Home-PC\Desktop\haiiii\ETAHN\ETAHN\ExpenseTracker.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ExpenseTrackers'
CREATE TABLE [dbo].[ExpenseTrackers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PersonId] int  NOT NULL,
    [Person_DetailsId] int  NOT NULL,
    [ExpenseId] int  NOT NULL,
    [Home_NeedsId] int  NOT NULL,
    [Report_TotalId] int  NOT NULL,
    [Report_By_PersonId] int  NOT NULL,
    [Report_By_MonthId] int  NOT NULL,
    [Report_By_DateId] int  NOT NULL,
    [Report_By_Search_And_FilterId] int  NOT NULL,
    [Family_MembersId] int  NOT NULL,
    [PersonId1] int  NOT NULL,
    [Report_By_Search_And_FilterId1] int  NOT NULL,
    [Report_By_DateId1] int  NOT NULL,
    [Report_By_MonthId1] int  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Person_Details'
CREATE TABLE [dbo].[Person_Details] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [EntityId] int  NOT NULL,
    [PhoneNumber1] bigint  NOT NULL,
    [PhoneNumber2] bigint  NOT NULL,
    [EmailId] nvarchar(max)  NOT NULL,
    [Occupation] nvarchar(max)  NOT NULL,
    [OccupativeAddress] nvarchar(max)  NOT NULL,
    [Salary] bigint  NOT NULL,
    [Person_TypeId] int  NOT NULL
);
GO

-- Creating table 'Person_Type'
CREATE TABLE [dbo].[Person_Type] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Father] nvarchar(max)  NOT NULL,
    [Mother] nvarchar(max)  NOT NULL,
    [Daughter] nvarchar(max)  NOT NULL,
    [Son] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Expenses'
CREATE TABLE [dbo].[Expenses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Amount] bigint  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Time] bigint  NOT NULL,
    [Expense_categoryId] int  NOT NULL,
    [Expense_categoryId1] int  NOT NULL
);
GO

-- Creating table 'Expense_category'
CREATE TABLE [dbo].[Expense_category] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Grocery] nvarchar(max)  NOT NULL,
    [Bills] bigint  NOT NULL,
    [Travel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ThisMonths'
CREATE TABLE [dbo].[ThisMonths] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Salary_Balance] bigint  NOT NULL,
    [Amount_Spent] bigint  NOT NULL,
    [ExpenseTrackerId] int  NOT NULL
);
GO

-- Creating table 'ExpenseTrackerAndHomeNeeds'
CREATE TABLE [dbo].[ExpenseTrackerAndHomeNeeds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Home_NeedsId] int  NOT NULL,
    [ExpenseTrackerId] int  NOT NULL
);
GO

-- Creating table 'Report_Total'
CREATE TABLE [dbo].[Report_Total] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Total_Income] bigint  NOT NULL,
    [Till_Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Report_By_Person'
CREATE TABLE [dbo].[Report_By_Person] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Person] nvarchar(max)  NOT NULL,
    [TotalIncome] bigint  NOT NULL,
    [Till_Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Report_By_Month'
CREATE TABLE [dbo].[Report_By_Month] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Month_Name] nvarchar(max)  NOT NULL,
    [Total_Income] bigint  NOT NULL,
    [Till_Month] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Report_By_Date'
CREATE TABLE [dbo].[Report_By_Date] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Total_Income] bigint  NOT NULL
);
GO

-- Creating table 'Report_By_Search_And_Filter'
CREATE TABLE [dbo].[Report_By_Search_And_Filter] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Person] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Home_Needs'
CREATE TABLE [dbo].[Home_Needs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Entity] nvarchar(max)  NOT NULL,
    [ExpenseTrackerAndHomeNeedsId] int  NOT NULL,
    [Monthly_NeedsId] int  NOT NULL,
    [LoansId] int  NOT NULL,
    [Check_ListId] int  NOT NULL,
    [Family_MembersId] int  NOT NULL,
    [VehicleId] int  NOT NULL,
    [VehileKm_TrackerId] int  NOT NULL,
    [Trip_Check_ListId] int  NOT NULL,
    [Trip_Check_ListId1] int  NOT NULL,
    [Monthly_NeedsId1] int  NOT NULL,
    [Family_MembersId1] int  NOT NULL,
    [Trip_Check_ListId2] int  NOT NULL,
    [VehileKm_Tracker_Id] int  NOT NULL
);
GO

-- Creating table 'Monthly_Needs'
CREATE TABLE [dbo].[Monthly_Needs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Amount] bigint  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Need_NameId] int  NOT NULL
);
GO

-- Creating table 'Loans'
CREATE TABLE [dbo].[Loans] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Loan_Reason] nvarchar(max)  NOT NULL,
    [Amount] bigint  NOT NULL,
    [Interest] bigint  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Amount_In_Due] bigint  NOT NULL
);
GO

-- Creating table 'Check_List'
CREATE TABLE [dbo].[Check_List] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [ToDo] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [StatusId] int  NOT NULL
);
GO

-- Creating table 'Status'
CREATE TABLE [dbo].[Status] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [InProcess] nvarchar(max)  NOT NULL,
    [Started] nvarchar(max)  NOT NULL,
    [Completed] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Family_Members'
CREATE TABLE [dbo].[Family_Members] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email_id] nvarchar(max)  NOT NULL,
    [Adhar_Number] bigint  NOT NULL,
    [PAN_CardNumber] bigint  NOT NULL,
    [Election_CardNumber] bigint  NOT NULL,
    [Licence_Number] bigint  NOT NULL,
    [Bank_Account_detais] nvarchar(max)  NOT NULL,
    [Mobile_Number1] bigint  NOT NULL,
    [Mobile_Number2] bigint  NOT NULL,
    [Landline] bigint  NOT NULL,
    [Occupation] nvarchar(max)  NOT NULL,
    [Occupation_Location] nvarchar(max)  NOT NULL,
    [Home_OwnershipId] int  NOT NULL,
    [LicencedForId] int  NOT NULL,
    [Member_TypeId] int  NOT NULL,
    [Home_OwnershipId1] int  NOT NULL,
    [LicencedForId1] int  NOT NULL
);
GO

-- Creating table 'LicencedFors'
CREATE TABLE [dbo].[LicencedFors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Car] nvarchar(max)  NOT NULL,
    [Bike] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Member_Type'
CREATE TABLE [dbo].[Member_Type] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Father] nvarchar(max)  NOT NULL,
    [Mother] nvarchar(max)  NOT NULL,
    [Son1] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Home_Ownership'
CREATE TABLE [dbo].[Home_Ownership] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rent] nvarchar(max)  NOT NULL,
    [Own] nvarchar(max)  NOT NULL,
    [Family_MembersId] int  NOT NULL
);
GO

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Insurane_date_Renewal] nvarchar(max)  NOT NULL,
    [RCBook_Details] nvarchar(max)  NOT NULL,
    [Service_DueDate] nvarchar(max)  NOT NULL,
    [OwnershipOfId] int  NOT NULL,
    [Having_LicenceId] int  NOT NULL,
    [OwnershipOfId1] int  NOT NULL,
    [Having_LicenceId1] int  NOT NULL
);
GO

-- Creating table 'OwnershipOfs'
CREATE TABLE [dbo].[OwnershipOfs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Bike] nvarchar(max)  NOT NULL,
    [Car] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Having_Licence'
CREATE TABLE [dbo].[Having_Licence] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Yes] nvarchar(max)  NOT NULL,
    [No] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VehileKm_Tracker'
CREATE TABLE [dbo].[VehileKm_Tracker] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Distance_Covered] nvarchar(max)  NOT NULL,
    [From] nvarchar(max)  NOT NULL,
    [To] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Fuel_FillUp_Amount] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Trip_Check_List'
CREATE TABLE [dbo].[Trip_Check_List] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Thing_Name] nvarchar(max)  NOT NULL,
    [Unit] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [Trip_ForId] int  NOT NULL,
    [TakenId] int  NOT NULL,
    [Trip_ForId1] int  NOT NULL,
    [TakenId1] int  NOT NULL
);
GO

-- Creating table 'Trip_For'
CREATE TABLE [dbo].[Trip_For] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Study] nvarchar(max)  NOT NULL,
    [Employment] nvarchar(max)  NOT NULL,
    [Tour] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Takens'
CREATE TABLE [dbo].[Takens] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Yes] nvarchar(max)  NOT NULL,
    [no] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Need_Name'
CREATE TABLE [dbo].[Need_Name] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Electricity_Bill] bigint  NOT NULL,
    [Fund] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [PK_ExpenseTrackers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Person_Details'
ALTER TABLE [dbo].[Person_Details]
ADD CONSTRAINT [PK_Person_Details]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Person_Type'
ALTER TABLE [dbo].[Person_Type]
ADD CONSTRAINT [PK_Person_Type]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Expense_category'
ALTER TABLE [dbo].[Expense_category]
ADD CONSTRAINT [PK_Expense_category]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ThisMonths'
ALTER TABLE [dbo].[ThisMonths]
ADD CONSTRAINT [PK_ThisMonths]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExpenseTrackerAndHomeNeeds'
ALTER TABLE [dbo].[ExpenseTrackerAndHomeNeeds]
ADD CONSTRAINT [PK_ExpenseTrackerAndHomeNeeds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Report_Total'
ALTER TABLE [dbo].[Report_Total]
ADD CONSTRAINT [PK_Report_Total]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Report_By_Person'
ALTER TABLE [dbo].[Report_By_Person]
ADD CONSTRAINT [PK_Report_By_Person]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Report_By_Month'
ALTER TABLE [dbo].[Report_By_Month]
ADD CONSTRAINT [PK_Report_By_Month]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Report_By_Date'
ALTER TABLE [dbo].[Report_By_Date]
ADD CONSTRAINT [PK_Report_By_Date]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Report_By_Search_And_Filter'
ALTER TABLE [dbo].[Report_By_Search_And_Filter]
ADD CONSTRAINT [PK_Report_By_Search_And_Filter]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [PK_Home_Needs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Monthly_Needs'
ALTER TABLE [dbo].[Monthly_Needs]
ADD CONSTRAINT [PK_Monthly_Needs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Loans'
ALTER TABLE [dbo].[Loans]
ADD CONSTRAINT [PK_Loans]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Check_List'
ALTER TABLE [dbo].[Check_List]
ADD CONSTRAINT [PK_Check_List]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Status'
ALTER TABLE [dbo].[Status]
ADD CONSTRAINT [PK_Status]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Family_Members'
ALTER TABLE [dbo].[Family_Members]
ADD CONSTRAINT [PK_Family_Members]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LicencedFors'
ALTER TABLE [dbo].[LicencedFors]
ADD CONSTRAINT [PK_LicencedFors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Member_Type'
ALTER TABLE [dbo].[Member_Type]
ADD CONSTRAINT [PK_Member_Type]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Home_Ownership'
ALTER TABLE [dbo].[Home_Ownership]
ADD CONSTRAINT [PK_Home_Ownership]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [PK_Vehicles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OwnershipOfs'
ALTER TABLE [dbo].[OwnershipOfs]
ADD CONSTRAINT [PK_OwnershipOfs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Having_Licence'
ALTER TABLE [dbo].[Having_Licence]
ADD CONSTRAINT [PK_Having_Licence]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VehileKm_Tracker'
ALTER TABLE [dbo].[VehileKm_Tracker]
ADD CONSTRAINT [PK_VehileKm_Tracker]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trip_Check_List'
ALTER TABLE [dbo].[Trip_Check_List]
ADD CONSTRAINT [PK_Trip_Check_List]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trip_For'
ALTER TABLE [dbo].[Trip_For]
ADD CONSTRAINT [PK_Trip_For]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Takens'
ALTER TABLE [dbo].[Takens]
ADD CONSTRAINT [PK_Takens]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Need_Name'
ALTER TABLE [dbo].[Need_Name]
ADD CONSTRAINT [PK_Need_Name]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LoansId] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [FK_Home_NeedsLoans]
    FOREIGN KEY ([LoansId])
    REFERENCES [dbo].[Loans]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_NeedsLoans'
CREATE INDEX [IX_FK_Home_NeedsLoans]
ON [dbo].[Home_Needs]
    ([LoansId]);
GO

-- Creating foreign key on [Check_ListId] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [FK_Home_NeedsCheck_List]
    FOREIGN KEY ([Check_ListId])
    REFERENCES [dbo].[Check_List]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_NeedsCheck_List'
CREATE INDEX [IX_FK_Home_NeedsCheck_List]
ON [dbo].[Home_Needs]
    ([Check_ListId]);
GO

-- Creating foreign key on [VehicleId] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [FK_Home_NeedsVehicle]
    FOREIGN KEY ([VehicleId])
    REFERENCES [dbo].[Vehicles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_NeedsVehicle'
CREATE INDEX [IX_FK_Home_NeedsVehicle]
ON [dbo].[Home_Needs]
    ([VehicleId]);
GO

-- Creating foreign key on [Monthly_NeedsId1] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [FK_Home_NeedsMonthly_Needs]
    FOREIGN KEY ([Monthly_NeedsId1])
    REFERENCES [dbo].[Monthly_Needs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_NeedsMonthly_Needs'
CREATE INDEX [IX_FK_Home_NeedsMonthly_Needs]
ON [dbo].[Home_Needs]
    ([Monthly_NeedsId1]);
GO

-- Creating foreign key on [Person_DetailsId] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerPerson_Details]
    FOREIGN KEY ([Person_DetailsId])
    REFERENCES [dbo].[Person_Details]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerPerson_Details'
CREATE INDEX [IX_FK_ExpenseTrackerPerson_Details]
ON [dbo].[ExpenseTrackers]
    ([Person_DetailsId]);
GO

-- Creating foreign key on [Person_TypeId] in table 'Person_Details'
ALTER TABLE [dbo].[Person_Details]
ADD CONSTRAINT [FK_Person_DetailsPerson_Type]
    FOREIGN KEY ([Person_TypeId])
    REFERENCES [dbo].[Person_Type]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Person_DetailsPerson_Type'
CREATE INDEX [IX_FK_Person_DetailsPerson_Type]
ON [dbo].[Person_Details]
    ([Person_TypeId]);
GO

-- Creating foreign key on [ExpenseId] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerExpense]
    FOREIGN KEY ([ExpenseId])
    REFERENCES [dbo].[Expenses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerExpense'
CREATE INDEX [IX_FK_ExpenseTrackerExpense]
ON [dbo].[ExpenseTrackers]
    ([ExpenseId]);
GO

-- Creating foreign key on [Expense_categoryId1] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_ExpenseExpense_category]
    FOREIGN KEY ([Expense_categoryId1])
    REFERENCES [dbo].[Expense_category]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseExpense_category'
CREATE INDEX [IX_FK_ExpenseExpense_category]
ON [dbo].[Expenses]
    ([Expense_categoryId1]);
GO

-- Creating foreign key on [ExpenseTrackerId] in table 'ThisMonths'
ALTER TABLE [dbo].[ThisMonths]
ADD CONSTRAINT [FK_ThisMonthExpenseTracker]
    FOREIGN KEY ([ExpenseTrackerId])
    REFERENCES [dbo].[ExpenseTrackers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ThisMonthExpenseTracker'
CREATE INDEX [IX_FK_ThisMonthExpenseTracker]
ON [dbo].[ThisMonths]
    ([ExpenseTrackerId]);
GO

-- Creating foreign key on [Home_NeedsId] in table 'ExpenseTrackerAndHomeNeeds'
ALTER TABLE [dbo].[ExpenseTrackerAndHomeNeeds]
ADD CONSTRAINT [FK_ExpenseTrackerAndHomeNeedsHome_Needs]
    FOREIGN KEY ([Home_NeedsId])
    REFERENCES [dbo].[Home_Needs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerAndHomeNeedsHome_Needs'
CREATE INDEX [IX_FK_ExpenseTrackerAndHomeNeedsHome_Needs]
ON [dbo].[ExpenseTrackerAndHomeNeeds]
    ([Home_NeedsId]);
GO

-- Creating foreign key on [ExpenseTrackerId] in table 'ExpenseTrackerAndHomeNeeds'
ALTER TABLE [dbo].[ExpenseTrackerAndHomeNeeds]
ADD CONSTRAINT [FK_ExpenseTrackerAndHomeNeedsExpenseTracker]
    FOREIGN KEY ([ExpenseTrackerId])
    REFERENCES [dbo].[ExpenseTrackers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerAndHomeNeedsExpenseTracker'
CREATE INDEX [IX_FK_ExpenseTrackerAndHomeNeedsExpenseTracker]
ON [dbo].[ExpenseTrackerAndHomeNeeds]
    ([ExpenseTrackerId]);
GO

-- Creating foreign key on [Report_TotalId] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerReport_Total]
    FOREIGN KEY ([Report_TotalId])
    REFERENCES [dbo].[Report_Total]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerReport_Total'
CREATE INDEX [IX_FK_ExpenseTrackerReport_Total]
ON [dbo].[ExpenseTrackers]
    ([Report_TotalId]);
GO

-- Creating foreign key on [Report_By_PersonId] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerReport_By_Person]
    FOREIGN KEY ([Report_By_PersonId])
    REFERENCES [dbo].[Report_By_Person]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerReport_By_Person'
CREATE INDEX [IX_FK_ExpenseTrackerReport_By_Person]
ON [dbo].[ExpenseTrackers]
    ([Report_By_PersonId]);
GO

-- Creating foreign key on [StatusId] in table 'Check_List'
ALTER TABLE [dbo].[Check_List]
ADD CONSTRAINT [FK_Check_ListStatus]
    FOREIGN KEY ([StatusId])
    REFERENCES [dbo].[Status]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_ListStatus'
CREATE INDEX [IX_FK_Check_ListStatus]
ON [dbo].[Check_List]
    ([StatusId]);
GO

-- Creating foreign key on [Member_TypeId] in table 'Family_Members'
ALTER TABLE [dbo].[Family_Members]
ADD CONSTRAINT [FK_Family_MembersMember_Type]
    FOREIGN KEY ([Member_TypeId])
    REFERENCES [dbo].[Member_Type]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Family_MembersMember_Type'
CREATE INDEX [IX_FK_Family_MembersMember_Type]
ON [dbo].[Family_Members]
    ([Member_TypeId]);
GO

-- Creating foreign key on [Family_MembersId1] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [FK_Home_NeedsFamily_Members]
    FOREIGN KEY ([Family_MembersId1])
    REFERENCES [dbo].[Family_Members]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_NeedsFamily_Members'
CREATE INDEX [IX_FK_Home_NeedsFamily_Members]
ON [dbo].[Home_Needs]
    ([Family_MembersId1]);
GO

-- Creating foreign key on [LicencedForId1] in table 'Family_Members'
ALTER TABLE [dbo].[Family_Members]
ADD CONSTRAINT [FK_Family_MembersLicencedFor]
    FOREIGN KEY ([LicencedForId1])
    REFERENCES [dbo].[LicencedFors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Family_MembersLicencedFor'
CREATE INDEX [IX_FK_Family_MembersLicencedFor]
ON [dbo].[Family_Members]
    ([LicencedForId1]);
GO

-- Creating foreign key on [Family_MembersId] in table 'Home_Ownership'
ALTER TABLE [dbo].[Home_Ownership]
ADD CONSTRAINT [FK_Home_OwnershipFamily_Members]
    FOREIGN KEY ([Family_MembersId])
    REFERENCES [dbo].[Family_Members]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_OwnershipFamily_Members'
CREATE INDEX [IX_FK_Home_OwnershipFamily_Members]
ON [dbo].[Home_Ownership]
    ([Family_MembersId]);
GO

-- Creating foreign key on [OwnershipOfId1] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [FK_VehicleOwnershipOf]
    FOREIGN KEY ([OwnershipOfId1])
    REFERENCES [dbo].[OwnershipOfs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleOwnershipOf'
CREATE INDEX [IX_FK_VehicleOwnershipOf]
ON [dbo].[Vehicles]
    ([OwnershipOfId1]);
GO

-- Creating foreign key on [Having_LicenceId1] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [FK_VehicleHaving_Licence]
    FOREIGN KEY ([Having_LicenceId1])
    REFERENCES [dbo].[Having_Licence]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleHaving_Licence'
CREATE INDEX [IX_FK_VehicleHaving_Licence]
ON [dbo].[Vehicles]
    ([Having_LicenceId1]);
GO

-- Creating foreign key on [VehileKm_Tracker_Id] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [FK_Home_NeedsVehileKm_Tracker]
    FOREIGN KEY ([VehileKm_Tracker_Id])
    REFERENCES [dbo].[VehileKm_Tracker]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_NeedsVehileKm_Tracker'
CREATE INDEX [IX_FK_Home_NeedsVehileKm_Tracker]
ON [dbo].[Home_Needs]
    ([VehileKm_Tracker_Id]);
GO

-- Creating foreign key on [Trip_ForId1] in table 'Trip_Check_List'
ALTER TABLE [dbo].[Trip_Check_List]
ADD CONSTRAINT [FK_Trip_Check_ListTrip_For]
    FOREIGN KEY ([Trip_ForId1])
    REFERENCES [dbo].[Trip_For]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Trip_Check_ListTrip_For'
CREATE INDEX [IX_FK_Trip_Check_ListTrip_For]
ON [dbo].[Trip_Check_List]
    ([Trip_ForId1]);
GO

-- Creating foreign key on [TakenId1] in table 'Trip_Check_List'
ALTER TABLE [dbo].[Trip_Check_List]
ADD CONSTRAINT [FK_Trip_Check_ListTaken]
    FOREIGN KEY ([TakenId1])
    REFERENCES [dbo].[Takens]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Trip_Check_ListTaken'
CREATE INDEX [IX_FK_Trip_Check_ListTaken]
ON [dbo].[Trip_Check_List]
    ([TakenId1]);
GO

-- Creating foreign key on [Trip_Check_ListId2] in table 'Home_Needs'
ALTER TABLE [dbo].[Home_Needs]
ADD CONSTRAINT [FK_Home_NeedsTrip_Check_List]
    FOREIGN KEY ([Trip_Check_ListId2])
    REFERENCES [dbo].[Trip_Check_List]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Home_NeedsTrip_Check_List'
CREATE INDEX [IX_FK_Home_NeedsTrip_Check_List]
ON [dbo].[Home_Needs]
    ([Trip_Check_ListId2]);
GO

-- Creating foreign key on [Need_NameId] in table 'Monthly_Needs'
ALTER TABLE [dbo].[Monthly_Needs]
ADD CONSTRAINT [FK_Monthly_NeedsNeed_Name]
    FOREIGN KEY ([Need_NameId])
    REFERENCES [dbo].[Need_Name]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Monthly_NeedsNeed_Name'
CREATE INDEX [IX_FK_Monthly_NeedsNeed_Name]
ON [dbo].[Monthly_Needs]
    ([Need_NameId]);
GO

-- Creating foreign key on [PersonId1] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerPerson]
    FOREIGN KEY ([PersonId1])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerPerson'
CREATE INDEX [IX_FK_ExpenseTrackerPerson]
ON [dbo].[ExpenseTrackers]
    ([PersonId1]);
GO

-- Creating foreign key on [Report_By_Search_And_FilterId1] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerReport_By_Search_And_Filter]
    FOREIGN KEY ([Report_By_Search_And_FilterId1])
    REFERENCES [dbo].[Report_By_Search_And_Filter]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerReport_By_Search_And_Filter'
CREATE INDEX [IX_FK_ExpenseTrackerReport_By_Search_And_Filter]
ON [dbo].[ExpenseTrackers]
    ([Report_By_Search_And_FilterId1]);
GO

-- Creating foreign key on [Report_By_DateId1] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerReport_By_Date]
    FOREIGN KEY ([Report_By_DateId1])
    REFERENCES [dbo].[Report_By_Date]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerReport_By_Date'
CREATE INDEX [IX_FK_ExpenseTrackerReport_By_Date]
ON [dbo].[ExpenseTrackers]
    ([Report_By_DateId1]);
GO

-- Creating foreign key on [Report_By_MonthId1] in table 'ExpenseTrackers'
ALTER TABLE [dbo].[ExpenseTrackers]
ADD CONSTRAINT [FK_ExpenseTrackerReport_By_Month]
    FOREIGN KEY ([Report_By_MonthId1])
    REFERENCES [dbo].[Report_By_Month]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseTrackerReport_By_Month'
CREATE INDEX [IX_FK_ExpenseTrackerReport_By_Month]
ON [dbo].[ExpenseTrackers]
    ([Report_By_MonthId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------