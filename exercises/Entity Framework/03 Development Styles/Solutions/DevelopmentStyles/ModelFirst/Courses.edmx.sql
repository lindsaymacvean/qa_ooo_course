
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/21/2014 09:37:39
-- Generated from EDMX file: C:\Users\Paul\documents\visual studio 2013\Projects\DevelopmentStyles\ModelFirst\Courses.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Courses];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CourseCourseRun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseRuns] DROP CONSTRAINT [FK_CourseCourseRun];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonCourseRun_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonCourseRun] DROP CONSTRAINT [FK_PersonCourseRun_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonCourseRun_CourseRun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonCourseRun] DROP CONSTRAINT [FK_PersonCourseRun_CourseRun];
GO
IF OBJECT_ID(N'[dbo].[FK_PublicRun_inherits_CourseRun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseRuns_PublicRun] DROP CONSTRAINT [FK_PublicRun_inherits_CourseRun];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyRun_inherits_CourseRun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseRuns_CompanyRun] DROP CONSTRAINT [FK_CompanyRun_inherits_CourseRun];
GO
IF OBJECT_ID(N'[dbo].[FK_OurSite_inherits_CompanyRun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseRuns_OurSite] DROP CONSTRAINT [FK_OurSite_inherits_CompanyRun];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanySite_inherits_CompanyRun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseRuns_CompanySite] DROP CONSTRAINT [FK_CompanySite_inherits_CompanyRun];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[CourseRuns]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseRuns];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[CourseRuns_PublicRun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseRuns_PublicRun];
GO
IF OBJECT_ID(N'[dbo].[CourseRuns_CompanyRun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseRuns_CompanyRun];
GO
IF OBJECT_ID(N'[dbo].[CourseRuns_OurSite]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseRuns_OurSite];
GO
IF OBJECT_ID(N'[dbo].[CourseRuns_CompanySite]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseRuns_CompanySite];
GO
IF OBJECT_ID(N'[dbo].[PersonCourseRun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonCourseRun];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseCode] nchar(10)  NOT NULL,
    [DaysDuration] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CourseRuns'
CREATE TABLE [dbo].[CourseRuns] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [CourseCourseCode] nchar(10)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Address_Line1] nvarchar(max)  NOT NULL,
    [Address_Town] nvarchar(max)  NOT NULL,
    [Address_Postcode] nvarchar(max)  NOT NULL,
    [Name_FirstName] nvarchar(max)  NOT NULL,
    [Name_LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CourseRuns_PublicRun'
CREATE TABLE [dbo].[CourseRuns_PublicRun] (
    [VMImage] nchar(50)  NOT NULL,
    [RoomCapacity] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'CourseRuns_CompanyRun'
CREATE TABLE [dbo].[CourseRuns_CompanyRun] (
    [MaxDelegates] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'CourseRuns_OurSite'
CREATE TABLE [dbo].[CourseRuns_OurSite] (
    [VMImage] nchar(50)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'CourseRuns_CompanySite'
CREATE TABLE [dbo].[CourseRuns_CompanySite] (
    [SetupInstructions] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PersonCourseRun'
CREATE TABLE [dbo].[PersonCourseRun] (
    [People_Id] int  NOT NULL,
    [CourseRuns_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CourseCode] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseCode] ASC);
GO

-- Creating primary key on [Id] in table 'CourseRuns'
ALTER TABLE [dbo].[CourseRuns]
ADD CONSTRAINT [PK_CourseRuns]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseRuns_PublicRun'
ALTER TABLE [dbo].[CourseRuns_PublicRun]
ADD CONSTRAINT [PK_CourseRuns_PublicRun]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseRuns_CompanyRun'
ALTER TABLE [dbo].[CourseRuns_CompanyRun]
ADD CONSTRAINT [PK_CourseRuns_CompanyRun]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseRuns_OurSite'
ALTER TABLE [dbo].[CourseRuns_OurSite]
ADD CONSTRAINT [PK_CourseRuns_OurSite]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseRuns_CompanySite'
ALTER TABLE [dbo].[CourseRuns_CompanySite]
ADD CONSTRAINT [PK_CourseRuns_CompanySite]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [People_Id], [CourseRuns_Id] in table 'PersonCourseRun'
ALTER TABLE [dbo].[PersonCourseRun]
ADD CONSTRAINT [PK_PersonCourseRun]
    PRIMARY KEY CLUSTERED ([People_Id], [CourseRuns_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CourseCourseCode] in table 'CourseRuns'
ALTER TABLE [dbo].[CourseRuns]
ADD CONSTRAINT [FK_CourseCourseRun]
    FOREIGN KEY ([CourseCourseCode])
    REFERENCES [dbo].[Courses]
        ([CourseCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseCourseRun'
CREATE INDEX [IX_FK_CourseCourseRun]
ON [dbo].[CourseRuns]
    ([CourseCourseCode]);
GO

-- Creating foreign key on [People_Id] in table 'PersonCourseRun'
ALTER TABLE [dbo].[PersonCourseRun]
ADD CONSTRAINT [FK_PersonCourseRun_Person]
    FOREIGN KEY ([People_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CourseRuns_Id] in table 'PersonCourseRun'
ALTER TABLE [dbo].[PersonCourseRun]
ADD CONSTRAINT [FK_PersonCourseRun_CourseRun]
    FOREIGN KEY ([CourseRuns_Id])
    REFERENCES [dbo].[CourseRuns]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonCourseRun_CourseRun'
CREATE INDEX [IX_FK_PersonCourseRun_CourseRun]
ON [dbo].[PersonCourseRun]
    ([CourseRuns_Id]);
GO

-- Creating foreign key on [Id] in table 'CourseRuns_PublicRun'
ALTER TABLE [dbo].[CourseRuns_PublicRun]
ADD CONSTRAINT [FK_PublicRun_inherits_CourseRun]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[CourseRuns]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'CourseRuns_CompanyRun'
ALTER TABLE [dbo].[CourseRuns_CompanyRun]
ADD CONSTRAINT [FK_CompanyRun_inherits_CourseRun]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[CourseRuns]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'CourseRuns_OurSite'
ALTER TABLE [dbo].[CourseRuns_OurSite]
ADD CONSTRAINT [FK_OurSite_inherits_CompanyRun]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[CourseRuns_CompanyRun]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'CourseRuns_CompanySite'
ALTER TABLE [dbo].[CourseRuns_CompanySite]
ADD CONSTRAINT [FK_CompanySite_inherits_CompanyRun]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[CourseRuns_CompanyRun]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------