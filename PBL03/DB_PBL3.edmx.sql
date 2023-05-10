
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/26/2023 00:44:30
-- Generated from EDMX file: D:\Luyen Code\PBL03-master\PBL03-master\PBL03\DB_PBL3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PBL3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Employee__Acc__693CA210]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK__Employee__Acc__693CA210];
GO
IF OBJECT_ID(N'[dbo].[FK__Bill__idEmployee__29221CFB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bills] DROP CONSTRAINT [FK__Bill__idEmployee__29221CFB];
GO
IF OBJECT_ID(N'[dbo].[FK__Bill__idTable__2A164134]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bills] DROP CONSTRAINT [FK__Bill__idTable__2A164134];
GO
IF OBJECT_ID(N'[dbo].[FK__BillHisto__IDBil__2EDAF651]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillHistories] DROP CONSTRAINT [FK__BillHisto__IDBil__2EDAF651];
GO
IF OBJECT_ID(N'[dbo].[FK__BillHisto__IDDis__2FCF1A8A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillHistories] DROP CONSTRAINT [FK__BillHisto__IDDis__2FCF1A8A];
GO
IF OBJECT_ID(N'[dbo].[FK__Salary__IDEmploy__0C85DE4D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salaries] DROP CONSTRAINT [FK__Salary__IDEmploy__0C85DE4D];
GO
IF OBJECT_ID(N'[dbo].[FK__WorkSched__IDEmp__05D8E0BE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkSchedules] DROP CONSTRAINT [FK__WorkSched__IDEmp__05D8E0BE];
GO
IF OBJECT_ID(N'[dbo].[FK__Food__IDCategory__403A8C7D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Foods] DROP CONSTRAINT [FK__Food__IDCategory__403A8C7D];
GO
IF OBJECT_ID(N'[dbo].[FK__OrderTabl__IDFoo__51300E55]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderTables] DROP CONSTRAINT [FK__OrderTabl__IDFoo__51300E55];
GO
IF OBJECT_ID(N'[dbo].[FK__OrderTabl__IDTab__5224328E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderTables] DROP CONSTRAINT [FK__OrderTabl__IDTab__5224328E];
GO
IF OBJECT_ID(N'[dbo].[FK__Salary__IDSchedu__0D7A0286]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salaries] DROP CONSTRAINT [FK__Salary__IDSchedu__0D7A0286];
GO
IF OBJECT_ID(N'[dbo].[FK__WorkSched__IDShi__06CD04F7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkSchedules] DROP CONSTRAINT [FK__WorkSched__IDShi__06CD04F7];
GO
IF OBJECT_ID(N'[dbo].[FK__TimeSheet__IDSch__09A971A2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TimeSheets] DROP CONSTRAINT [FK__TimeSheet__IDSch__09A971A2];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accounts];
GO
IF OBJECT_ID(N'[dbo].[Bills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bills];
GO
IF OBJECT_ID(N'[dbo].[BillHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BillHistories];
GO
IF OBJECT_ID(N'[dbo].[Costs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Costs];
GO
IF OBJECT_ID(N'[dbo].[Discounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discounts];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Foods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Foods];
GO
IF OBJECT_ID(N'[dbo].[FoodCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FoodCategories];
GO
IF OBJECT_ID(N'[dbo].[OrderTables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderTables];
GO
IF OBJECT_ID(N'[dbo].[Revenues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Revenues];
GO
IF OBJECT_ID(N'[dbo].[Salaries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Salaries];
GO
IF OBJECT_ID(N'[dbo].[ShiftWorks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ShiftWorks];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TableFoods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TableFoods];
GO
IF OBJECT_ID(N'[dbo].[TimeSheets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TimeSheets];
GO
IF OBJECT_ID(N'[dbo].[WorkSchedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkSchedules];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [Username] varchar(50)  NOT NULL,
    [PW] varchar(50)  NOT NULL,
    [NameType] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Bills'
CREATE TABLE [dbo].[Bills] (
    [ID_Bill] int IDENTITY(1,1) NOT NULL,
    [TimeCheckIn] datetime  NOT NULL,
    [TimeCheckOut] datetime  NOT NULL,
    [idEmployee] varchar(10)  NOT NULL,
    [idTable] varchar(10)  NOT NULL,
    [TotalMoney] real  NOT NULL,
    [statusBill] bit  NOT NULL
);
GO

-- Creating table 'BillHistories'
CREATE TABLE [dbo].[BillHistories] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IDBill] int  NOT NULL,
    [DatePay] datetime  NOT NULL,
    [TotalMoney] real  NOT NULL,
    [MoneyCustomerPay] real  NOT NULL,
    [IDDiscount] varchar(10)  NOT NULL,
    [Exchange] real  NOT NULL
);
GO

-- Creating table 'Costs'
CREATE TABLE [dbo].[Costs] (
    [ID_Cost] varchar(10)  NOT NULL,
    [CostOfDate] datetime  NOT NULL,
    [CostBuyMaterials] real  NOT NULL,
    [CostEmployee] real  NOT NULL,
    [CostTransportation] real  NOT NULL,
    [CostAdvertisement] real  NOT NULL
);
GO

-- Creating table 'Discounts'
CREATE TABLE [dbo].[Discounts] (
    [ID_Discount] varchar(10)  NOT NULL,
    [NameDiscount] nvarchar(100)  NOT NULL,
    [DiscountRate] real  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [ID_Employee] varchar(10)  NOT NULL,
    [Name_Employee] nvarchar(50)  NOT NULL,
    [PhoneNumber] varchar(10)  NOT NULL,
    [Address_Employee] nvarchar(100)  NOT NULL,
    [Salary] real  NOT NULL,
    [Acc] varchar(50)  NOT NULL
);
GO

-- Creating table 'Foods'
CREATE TABLE [dbo].[Foods] (
    [ID_Food] varchar(10)  NOT NULL,
    [NameFood] nvarchar(100)  NOT NULL,
    [Price] real  NOT NULL,
    [StatusFood] bit  NOT NULL,
    [IDCategory] varchar(10)  NOT NULL,
    [QuantityFood] int  NOT NULL,
    [PictureFood] varchar(200)  NOT NULL
);
GO

-- Creating table 'FoodCategories'
CREATE TABLE [dbo].[FoodCategories] (
    [ID_Category] varchar(10)  NOT NULL,
    [NameCategory] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'OrderTables'
CREATE TABLE [dbo].[OrderTables] (
    [ID_Order] varchar(10)  NOT NULL,
    [IDFood] varchar(10)  NOT NULL,
    [Quantity] int  NOT NULL,
    [IDTable] varchar(10)  NOT NULL
);
GO

-- Creating table 'Revenues'
CREATE TABLE [dbo].[Revenues] (
    [ID_Revenue] varchar(10)  NOT NULL,
    [RevenueInDate] datetime  NOT NULL,
    [TotalInDate] real  NOT NULL,
    [NumberOfBill] int  NOT NULL,
    [NumberOfCustomer] int  NOT NULL
);
GO

-- Creating table 'Salaries'
CREATE TABLE [dbo].[Salaries] (
    [ID_Salary] varchar(10)  NOT NULL,
    [IDEmployee] varchar(10)  NOT NULL,
    [IDSchedule] int  NOT NULL,
    [SalaryBasic] real  NOT NULL,
    [WorkingHours] real  NOT NULL,
    [SalaryTotal] real  NOT NULL
);
GO

-- Creating table 'ShiftWorks'
CREATE TABLE [dbo].[ShiftWorks] (
    [ID_Shift] int  NOT NULL,
    [NameShift] nvarchar(50)  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [EndTime] datetime  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TableFoods'
CREATE TABLE [dbo].[TableFoods] (
    [ID_Table] varchar(10)  NOT NULL,
    [statusTable] bit  NOT NULL,
    [Capacity] int  NOT NULL
);
GO

-- Creating table 'TimeSheets'
CREATE TABLE [dbo].[TimeSheets] (
    [ID_TimeSheet] int  NOT NULL,
    [IDSchedule] int  NOT NULL,
    [TimeCheckIn] datetime  NOT NULL,
    [TimeCheckOut] datetime  NOT NULL
);
GO

-- Creating table 'WorkSchedules'
CREATE TABLE [dbo].[WorkSchedules] (
    [ID_Schedule] int  NOT NULL,
    [IDEmployee] varchar(10)  NOT NULL,
    [IDShift] int  NOT NULL,
    [DateWork] datetime  NOT NULL,
    [Note] nvarchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Username] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- Creating primary key on [ID_Bill] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [PK_Bills]
    PRIMARY KEY CLUSTERED ([ID_Bill] ASC);
GO

-- Creating primary key on [ID] in table 'BillHistories'
ALTER TABLE [dbo].[BillHistories]
ADD CONSTRAINT [PK_BillHistories]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID_Cost] in table 'Costs'
ALTER TABLE [dbo].[Costs]
ADD CONSTRAINT [PK_Costs]
    PRIMARY KEY CLUSTERED ([ID_Cost] ASC);
GO

-- Creating primary key on [ID_Discount] in table 'Discounts'
ALTER TABLE [dbo].[Discounts]
ADD CONSTRAINT [PK_Discounts]
    PRIMARY KEY CLUSTERED ([ID_Discount] ASC);
GO

-- Creating primary key on [ID_Employee] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([ID_Employee] ASC);
GO

-- Creating primary key on [ID_Food] in table 'Foods'
ALTER TABLE [dbo].[Foods]
ADD CONSTRAINT [PK_Foods]
    PRIMARY KEY CLUSTERED ([ID_Food] ASC);
GO

-- Creating primary key on [ID_Category] in table 'FoodCategories'
ALTER TABLE [dbo].[FoodCategories]
ADD CONSTRAINT [PK_FoodCategories]
    PRIMARY KEY CLUSTERED ([ID_Category] ASC);
GO

-- Creating primary key on [ID_Order] in table 'OrderTables'
ALTER TABLE [dbo].[OrderTables]
ADD CONSTRAINT [PK_OrderTables]
    PRIMARY KEY CLUSTERED ([ID_Order] ASC);
GO

-- Creating primary key on [ID_Revenue] in table 'Revenues'
ALTER TABLE [dbo].[Revenues]
ADD CONSTRAINT [PK_Revenues]
    PRIMARY KEY CLUSTERED ([ID_Revenue] ASC);
GO

-- Creating primary key on [ID_Salary] in table 'Salaries'
ALTER TABLE [dbo].[Salaries]
ADD CONSTRAINT [PK_Salaries]
    PRIMARY KEY CLUSTERED ([ID_Salary] ASC);
GO

-- Creating primary key on [ID_Shift] in table 'ShiftWorks'
ALTER TABLE [dbo].[ShiftWorks]
ADD CONSTRAINT [PK_ShiftWorks]
    PRIMARY KEY CLUSTERED ([ID_Shift] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID_Table] in table 'TableFoods'
ALTER TABLE [dbo].[TableFoods]
ADD CONSTRAINT [PK_TableFoods]
    PRIMARY KEY CLUSTERED ([ID_Table] ASC);
GO

-- Creating primary key on [ID_TimeSheet] in table 'TimeSheets'
ALTER TABLE [dbo].[TimeSheets]
ADD CONSTRAINT [PK_TimeSheets]
    PRIMARY KEY CLUSTERED ([ID_TimeSheet] ASC);
GO

-- Creating primary key on [ID_Schedule] in table 'WorkSchedules'
ALTER TABLE [dbo].[WorkSchedules]
ADD CONSTRAINT [PK_WorkSchedules]
    PRIMARY KEY CLUSTERED ([ID_Schedule] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Acc] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK__Employee__Acc__693CA210]
    FOREIGN KEY ([Acc])
    REFERENCES [dbo].[Accounts]
        ([Username])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Employee__Acc__693CA210'
CREATE INDEX [IX_FK__Employee__Acc__693CA210]
ON [dbo].[Employees]
    ([Acc]);
GO

-- Creating foreign key on [idEmployee] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [FK__Bill__idEmployee__29221CFB]
    FOREIGN KEY ([idEmployee])
    REFERENCES [dbo].[Employees]
        ([ID_Employee])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Bill__idEmployee__29221CFB'
CREATE INDEX [IX_FK__Bill__idEmployee__29221CFB]
ON [dbo].[Bills]
    ([idEmployee]);
GO

-- Creating foreign key on [idTable] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [FK__Bill__idTable__2A164134]
    FOREIGN KEY ([idTable])
    REFERENCES [dbo].[TableFoods]
        ([ID_Table])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Bill__idTable__2A164134'
CREATE INDEX [IX_FK__Bill__idTable__2A164134]
ON [dbo].[Bills]
    ([idTable]);
GO

-- Creating foreign key on [IDBill] in table 'BillHistories'
ALTER TABLE [dbo].[BillHistories]
ADD CONSTRAINT [FK__BillHisto__IDBil__2EDAF651]
    FOREIGN KEY ([IDBill])
    REFERENCES [dbo].[Bills]
        ([ID_Bill])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__BillHisto__IDBil__2EDAF651'
CREATE INDEX [IX_FK__BillHisto__IDBil__2EDAF651]
ON [dbo].[BillHistories]
    ([IDBill]);
GO

-- Creating foreign key on [IDDiscount] in table 'BillHistories'
ALTER TABLE [dbo].[BillHistories]
ADD CONSTRAINT [FK__BillHisto__IDDis__2FCF1A8A]
    FOREIGN KEY ([IDDiscount])
    REFERENCES [dbo].[Discounts]
        ([ID_Discount])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__BillHisto__IDDis__2FCF1A8A'
CREATE INDEX [IX_FK__BillHisto__IDDis__2FCF1A8A]
ON [dbo].[BillHistories]
    ([IDDiscount]);
GO

-- Creating foreign key on [IDEmployee] in table 'Salaries'
ALTER TABLE [dbo].[Salaries]
ADD CONSTRAINT [FK__Salary__IDEmploy__0C85DE4D]
    FOREIGN KEY ([IDEmployee])
    REFERENCES [dbo].[Employees]
        ([ID_Employee])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Salary__IDEmploy__0C85DE4D'
CREATE INDEX [IX_FK__Salary__IDEmploy__0C85DE4D]
ON [dbo].[Salaries]
    ([IDEmployee]);
GO

-- Creating foreign key on [IDEmployee] in table 'WorkSchedules'
ALTER TABLE [dbo].[WorkSchedules]
ADD CONSTRAINT [FK__WorkSched__IDEmp__05D8E0BE]
    FOREIGN KEY ([IDEmployee])
    REFERENCES [dbo].[Employees]
        ([ID_Employee])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__WorkSched__IDEmp__05D8E0BE'
CREATE INDEX [IX_FK__WorkSched__IDEmp__05D8E0BE]
ON [dbo].[WorkSchedules]
    ([IDEmployee]);
GO

-- Creating foreign key on [IDCategory] in table 'Foods'
ALTER TABLE [dbo].[Foods]
ADD CONSTRAINT [FK__Food__IDCategory__403A8C7D]
    FOREIGN KEY ([IDCategory])
    REFERENCES [dbo].[FoodCategories]
        ([ID_Category])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Food__IDCategory__403A8C7D'
CREATE INDEX [IX_FK__Food__IDCategory__403A8C7D]
ON [dbo].[Foods]
    ([IDCategory]);
GO

-- Creating foreign key on [IDFood] in table 'OrderTables'
ALTER TABLE [dbo].[OrderTables]
ADD CONSTRAINT [FK__OrderTabl__IDFoo__51300E55]
    FOREIGN KEY ([IDFood])
    REFERENCES [dbo].[Foods]
        ([ID_Food])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OrderTabl__IDFoo__51300E55'
CREATE INDEX [IX_FK__OrderTabl__IDFoo__51300E55]
ON [dbo].[OrderTables]
    ([IDFood]);
GO

-- Creating foreign key on [IDTable] in table 'OrderTables'
ALTER TABLE [dbo].[OrderTables]
ADD CONSTRAINT [FK__OrderTabl__IDTab__5224328E]
    FOREIGN KEY ([IDTable])
    REFERENCES [dbo].[TableFoods]
        ([ID_Table])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OrderTabl__IDTab__5224328E'
CREATE INDEX [IX_FK__OrderTabl__IDTab__5224328E]
ON [dbo].[OrderTables]
    ([IDTable]);
GO

-- Creating foreign key on [IDSchedule] in table 'Salaries'
ALTER TABLE [dbo].[Salaries]
ADD CONSTRAINT [FK__Salary__IDSchedu__0D7A0286]
    FOREIGN KEY ([IDSchedule])
    REFERENCES [dbo].[WorkSchedules]
        ([ID_Schedule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Salary__IDSchedu__0D7A0286'
CREATE INDEX [IX_FK__Salary__IDSchedu__0D7A0286]
ON [dbo].[Salaries]
    ([IDSchedule]);
GO

-- Creating foreign key on [IDShift] in table 'WorkSchedules'
ALTER TABLE [dbo].[WorkSchedules]
ADD CONSTRAINT [FK__WorkSched__IDShi__06CD04F7]
    FOREIGN KEY ([IDShift])
    REFERENCES [dbo].[ShiftWorks]
        ([ID_Shift])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__WorkSched__IDShi__06CD04F7'
CREATE INDEX [IX_FK__WorkSched__IDShi__06CD04F7]
ON [dbo].[WorkSchedules]
    ([IDShift]);
GO

-- Creating foreign key on [IDSchedule] in table 'TimeSheets'
ALTER TABLE [dbo].[TimeSheets]
ADD CONSTRAINT [FK__TimeSheet__IDSch__09A971A2]
    FOREIGN KEY ([IDSchedule])
    REFERENCES [dbo].[WorkSchedules]
        ([ID_Schedule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TimeSheet__IDSch__09A971A2'
CREATE INDEX [IX_FK__TimeSheet__IDSch__09A971A2]
ON [dbo].[TimeSheets]
    ([IDSchedule]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------