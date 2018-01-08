
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/27/2017 21:43:05
-- Generated from EDMX file: C:\Users\Home-PC\Desktop\haiiii\sea\sea\studentform.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SMS];
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

-- Creating table 'Admission_form'
CREATE TABLE [dbo].[Admission_form] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Enquiry_TypeId] int  NOT NULL,
    [Department] nvarchar(max)  NOT NULL,
    [Student_TypeId] int  NOT NULL,
    [QuotaId] int  NOT NULL,
    [Tenth_Percentage] bigint  NOT NULL,
    [Plustwo_Percentage] bigint  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Phone_Num] bigint  NOT NULL
);
GO

-- Creating table 'Enquiry_Type'
CREATE TABLE [dbo].[Enquiry_Type] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Student_Type'
CREATE TABLE [dbo].[Student_Type] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Quotas'
CREATE TABLE [dbo].[Quotas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Reg_Id] bigint  NOT NULL,
    [Department] nvarchar(max)  NOT NULL,
    [Batch] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Phone_Num] bigint  NOT NULL,
    [TeamviewerID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Staffs'
CREATE TABLE [dbo].[Staffs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Staff_Num] bigint  NOT NULL,
    [Department] nvarchar(max)  NOT NULL,
    [Designation] nvarchar(max)  NOT NULL,
    [Subject_Handling] nvarchar(max)  NOT NULL,
    [Staff_TypeId] int  NOT NULL,
    [Phone_No] bigint  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Teamviewer_Id] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Staff_Type'
CREATE TABLE [dbo].[Staff_Type] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Authorities'
CREATE TABLE [dbo].[Authorities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Message] nvarchar(max)  NOT NULL,
    [Topic] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Classrooms'
CREATE TABLE [dbo].[Classrooms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [Class_No] bigint  NOT NULL,
    [Room_TypeId] int  NOT NULL
);
GO

-- Creating table 'Room_Type'
CREATE TABLE [dbo].[Room_Type] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Maps'
CREATE TABLE [dbo].[Maps] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Floor] nvarchar(max)  NOT NULL,
    [Room_No] bigint  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Libraries'
CREATE TABLE [dbo].[Libraries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Book_Name] bigint  NOT NULL,
    [Author] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Department] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Fees'
CREATE TABLE [dbo].[Fees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fee_Amount] bigint  NOT NULL,
    [Department] nvarchar(max)  NOT NULL,
    [Student_Regno] bigint  NOT NULL,
    [Student_Name] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Semester] bigint  NOT NULL,
    [Year] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Admission_form'
ALTER TABLE [dbo].[Admission_form]
ADD CONSTRAINT [PK_Admission_form]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Enquiry_Type'
ALTER TABLE [dbo].[Enquiry_Type]
ADD CONSTRAINT [PK_Enquiry_Type]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Student_Type'
ALTER TABLE [dbo].[Student_Type]
ADD CONSTRAINT [PK_Student_Type]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Quotas'
ALTER TABLE [dbo].[Quotas]
ADD CONSTRAINT [PK_Quotas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Staffs'
ALTER TABLE [dbo].[Staffs]
ADD CONSTRAINT [PK_Staffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Staff_Type'
ALTER TABLE [dbo].[Staff_Type]
ADD CONSTRAINT [PK_Staff_Type]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Authorities'
ALTER TABLE [dbo].[Authorities]
ADD CONSTRAINT [PK_Authorities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Classrooms'
ALTER TABLE [dbo].[Classrooms]
ADD CONSTRAINT [PK_Classrooms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Room_Type'
ALTER TABLE [dbo].[Room_Type]
ADD CONSTRAINT [PK_Room_Type]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Maps'
ALTER TABLE [dbo].[Maps]
ADD CONSTRAINT [PK_Maps]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Libraries'
ALTER TABLE [dbo].[Libraries]
ADD CONSTRAINT [PK_Libraries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fees'
ALTER TABLE [dbo].[Fees]
ADD CONSTRAINT [PK_Fees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Enquiry_TypeId] in table 'Admission_form'
ALTER TABLE [dbo].[Admission_form]
ADD CONSTRAINT [FK_Admission_formEnquiry_Type]
    FOREIGN KEY ([Enquiry_TypeId])
    REFERENCES [dbo].[Enquiry_Type]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Admission_formEnquiry_Type'
CREATE INDEX [IX_FK_Admission_formEnquiry_Type]
ON [dbo].[Admission_form]
    ([Enquiry_TypeId]);
GO

-- Creating foreign key on [Student_TypeId] in table 'Admission_form'
ALTER TABLE [dbo].[Admission_form]
ADD CONSTRAINT [FK_Admission_formStudent_Type]
    FOREIGN KEY ([Student_TypeId])
    REFERENCES [dbo].[Student_Type]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Admission_formStudent_Type'
CREATE INDEX [IX_FK_Admission_formStudent_Type]
ON [dbo].[Admission_form]
    ([Student_TypeId]);
GO

-- Creating foreign key on [QuotaId] in table 'Admission_form'
ALTER TABLE [dbo].[Admission_form]
ADD CONSTRAINT [FK_Admission_formQuota]
    FOREIGN KEY ([QuotaId])
    REFERENCES [dbo].[Quotas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Admission_formQuota'
CREATE INDEX [IX_FK_Admission_formQuota]
ON [dbo].[Admission_form]
    ([QuotaId]);
GO

-- Creating foreign key on [Staff_TypeId] in table 'Staffs'
ALTER TABLE [dbo].[Staffs]
ADD CONSTRAINT [FK_StaffStaff_Type]
    FOREIGN KEY ([Staff_TypeId])
    REFERENCES [dbo].[Staff_Type]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StaffStaff_Type'
CREATE INDEX [IX_FK_StaffStaff_Type]
ON [dbo].[Staffs]
    ([Staff_TypeId]);
GO

-- Creating foreign key on [Room_TypeId] in table 'Classrooms'
ALTER TABLE [dbo].[Classrooms]
ADD CONSTRAINT [FK_ClassroomRoom_Type]
    FOREIGN KEY ([Room_TypeId])
    REFERENCES [dbo].[Room_Type]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassroomRoom_Type'
CREATE INDEX [IX_FK_ClassroomRoom_Type]
ON [dbo].[Classrooms]
    ([Room_TypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------