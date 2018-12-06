CREATE PROCEDURE Event_Create	
	@sport varchar,
	@date date,
	@competition varchar
AS
	INSERT INTO [Events](sport, [Date], Competition) VALUES (@sport,@date,@competition )


-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/28/2016 08:40:12
-- Generated from EDMX file: c:\users\chris\documents\visual studio 2015\Projects\WcfService_Sport\WcfService_Sport\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
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

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Sport] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Competition] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Competitor] nvarchar(max)  NOT NULL,
    [Points] smallint  NOT NULL,
    [Events_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Events_Id] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_EventsResult]
    FOREIGN KEY ([Events_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventsResult'
CREATE INDEX [IX_FK_EventsResult]
ON [dbo].[Results]
    ([Events_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------