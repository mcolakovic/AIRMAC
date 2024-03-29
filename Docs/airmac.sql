USE [master]
GO
/****** Object:  Database [DIPLOMSKI]    Script Date: 07/08/2023 3:57:35 PM ******/
CREATE DATABASE [DIPLOMSKI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DIPLOMSKI', FILENAME = N'C:\Users\Administrator\DIPLOMSKI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DIPLOMSKI_log', FILENAME = N'C:\Users\Administrator\DIPLOMSKI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DIPLOMSKI] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DIPLOMSKI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DIPLOMSKI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET ARITHABORT OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DIPLOMSKI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DIPLOMSKI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DIPLOMSKI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET TRUSTWORTHY ON 
GO
ALTER DATABASE [DIPLOMSKI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DIPLOMSKI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DIPLOMSKI] SET  MULTI_USER 
GO
ALTER DATABASE [DIPLOMSKI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DIPLOMSKI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DIPLOMSKI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DIPLOMSKI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DIPLOMSKI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DIPLOMSKI] SET QUERY_STORE = OFF
GO
USE [DIPLOMSKI]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DIPLOMSKI]
GO
/****** Object:  User [air]    Script Date: 07/08/2023 3:57:35 PM ******/
CREATE USER [air] FOR LOGIN [air] WITH DEFAULT_SCHEMA=[airmac_schema]
GO
ALTER ROLE [db_datareader] ADD MEMBER [air]
GO
/****** Object:  Schema [airmac_schema]    Script Date: 07/08/2023 3:57:35 PM ******/
CREATE SCHEMA [airmac_schema]
GO
/****** Object:  UserDefinedFunction [dbo].[hours_add]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[hours_add](@h1 decimal(18,2), @h2 decimal(18,2))  
RETURNS decimal(18,2) AS  
BEGIN 
DECLARE
@z1 AS int,
@z2 AS int

SELECT @z1 =  cast(@h1 * 100 / 100 as int) * 60 + cast(@h1 * 100 as int)  % 100
SELECT @z2 =  cast(@h2 * 100 / 100 as int) * 60 + cast(@h2 * 100 as int)  % 100
return cast((@z1 + @z2) / 60 as int) + cast((@z1 + @z2) % 60 as decimal(18,2)) /100 
END

GO
/****** Object:  UserDefinedFunction [dbo].[hours_sub]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[hours_sub](@h1 decimal(18,2), @h2 decimal(18,2))  
RETURNS decimal(18,2) AS  
BEGIN 
DECLARE
@z1 AS int,
@z2 AS int

SELECT @z1 =  cast(@h1 * 100 / 100 as int) * 60 + cast(@h1 * 100 as int)  % 100
SELECT @z2 =  cast(@h2 * 100 / 100 as int) * 60 + cast(@h2 * 100 as int)  % 100
return cast((@z1 - @z2) / 60 as int) + cast((@z1 - @z2) % 60 as decimal(18,2)) /100 
END
GO
/****** Object:  Table [dbo].[Aircraft]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aircraft](
	[RegistrationNumber] [varchar](10) NOT NULL,
	[SerialNumber] [varchar](50) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[ID_Airport] [numeric](18, 0) NOT NULL,
	[LastACHours] [decimal](18, 2) NOT NULL,
	[LastACCycles] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Aircraft] PRIMARY KEY CLUSTERED 
(
	[RegistrationNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Airports]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Airports](
	[ID_Airport] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NameOfAirports] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Airports] PRIMARY KEY CLUSTERED 
(
	[ID_Airport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credentials](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](64) NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogBook]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogBook](
	[ID_LogBook] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ID_Airport_FROM] [numeric](18, 0) NOT NULL,
	[ID_Airport_TO] [numeric](18, 0) NOT NULL,
	[FlightDate] [date] NOT NULL,
	[FlightNumber] [varchar](10) NOT NULL,
	[RegistrationNumber] [varchar](10) NOT NULL,
	[FlightTimeStart] [datetime] NOT NULL,
	[FlightTimeStop] [datetime] NOT NULL,
	[PreviousACHours] [numeric](18, 2) NOT NULL,
	[PreviousACCycles] [numeric](18, 0) NOT NULL,
	[NextACHours] [numeric](18, 2) NOT NULL,
	[NextACCycles] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_LogBook] PRIMARY KEY CLUSTERED 
(
	[ID_LogBook] ASC,
	[ID_Airport_FROM] ASC,
	[ID_Airport_TO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RotableParts]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RotableParts](
	[ID_RotableParts] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PartNumber] [varchar](20) NOT NULL,
	[SerialNumber] [varchar](20) NOT NULL,
	[Description] [varchar](max) NOT NULL,
 CONSTRAINT [PK_RotableParts] PRIMARY KEY CLUSTERED 
(
	[ID_RotableParts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RotablePartsAircraft]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RotablePartsAircraft](
	[ID_RotablePartsLog] [numeric](18, 0) NOT NULL,
	[ID_RotableParts] [numeric](18, 0) NOT NULL,
	[RegistrationNumber] [varchar](10) NOT NULL,
	[AircraftHours] [numeric](18, 2) NOT NULL,
	[AircraftCycles] [numeric](18, 0) NOT NULL,
	[InstalationDate] [date] NOT NULL,
	[HoursOperationalLimit] [numeric](18, 2) NULL,
	[CyclesOperationalLimit] [numeric](18, 0) NULL,
	[DaysOperationalLimit] [numeric](18, 0) NULL,
	[StorageLimit] [numeric](18, 0) NULL,
	[TimeSinceNew] [numeric](18, 2) NULL,
	[CyclesSinceNew] [numeric](18, 0) NULL,
	[DaysSinceNew] [numeric](18, 0) NULL,
	[TimeSinceOverhaul] [numeric](18, 2) NULL,
	[CyclesSinceOverhaul] [numeric](18, 0) NULL,
	[DaysSinceOverhaul] [numeric](18, 0) NULL,
	[ExpireOnHours] [numeric](18, 2) NULL,
	[ExpireOnCycles] [numeric](18, 0) NULL,
	[ExpireAtDate] [date] NULL,
 CONSTRAINT [PK_RotablePartsAircraft] PRIMARY KEY CLUSTERED 
(
	[ID_RotablePartsLog] ASC,
	[ID_RotableParts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RotablePartsLog]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RotablePartsLog](
	[ID_RotablePartsLog] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ID_RotableParts] [numeric](18, 0) NOT NULL,
	[ID_SubClass] [int] NOT NULL,
 CONSTRAINT [PK_RotablePartsLog] PRIMARY KEY CLUSTERED 
(
	[ID_RotablePartsLog] ASC,
	[ID_RotableParts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RotablePartsService]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RotablePartsService](
	[ID_RotablePartsLog] [numeric](18, 0) NOT NULL,
	[ID_RotableParts] [numeric](18, 0) NOT NULL,
	[WorkOrder] [varchar](50) NOT NULL,
	[WorkOrderDescription] [varchar](max) NOT NULL,
	[HoursOperationalLimit] [numeric](18, 2) NULL,
	[CyclesOperationalLimit] [numeric](18, 0) NULL,
	[DaysOperationalLimit] [numeric](18, 0) NULL,
	[StorageLimit] [numeric](18, 0) NULL,
	[TimeSinceNew] [numeric](18, 2) NULL,
	[CyclesSinceNew] [numeric](18, 0) NULL,
	[DaysCinceNew] [numeric](18, 0) NULL,
	[TimeSinceOverhaul] [numeric](18, 2) NULL,
	[CyclesSinceOverhaul] [numeric](18, 0) NULL,
	[DaysCinceOverhaul] [numeric](18, 0) NULL,
	[ID_ResultOfInspection] [numeric](18, 0) NULL,
	[NewHoursOperationalLimit] [numeric](18, 2) NULL,
	[NewCyclesOperationalLimit] [numeric](18, 0) NULL,
	[NewDaysOperationalLimit] [numeric](18, 0) NULL,
	[NewStorageLimit] [numeric](18, 0) NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_RotablePartsService] PRIMARY KEY CLUSTERED 
(
	[ID_RotablePartsLog] ASC,
	[ID_RotableParts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RotablePartsStock]    Script Date: 07/08/2023 3:57:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RotablePartsStock](
	[ID_RotablePartsLog] [numeric](18, 0) NOT NULL,
	[ID_RotableParts] [numeric](18, 0) NOT NULL,
	[RegistrationNumber] [varchar](10) NULL,
	[AircraftHours] [numeric](18, 2) NULL,
	[AircraftCycles] [numeric](18, 0) NULL,
	[DateOfEntry] [date] NOT NULL,
	[HoursOperationalLimit] [numeric](18, 2) NULL,
	[CyclesOperationalLimit] [numeric](18, 0) NULL,
	[DaysOperationalLimit] [numeric](18, 0) NULL,
	[StorageLimit] [numeric](18, 0) NULL,
	[TimeSinceNew] [numeric](18, 2) NULL,
	[CyclesSinceNew] [numeric](18, 0) NULL,
	[DaysSinceNew] [numeric](18, 0) NULL,
	[TimeSinceOverhaul] [numeric](18, 2) NULL,
	[CyclesSinceOverhaul] [numeric](18, 0) NULL,
	[DaysSinceOverhaul] [numeric](18, 0) NULL,
	[ExpireAtDate] [date] NULL,
	[IsInitial] [bit] NOT NULL,
 CONSTRAINT [PK_RotablePartsStock] PRIMARY KEY CLUSTERED 
(
	[ID_RotablePartsLog] ASC,
	[ID_RotableParts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aircraft]  WITH CHECK ADD  CONSTRAINT [FK_Aircraft_Airports] FOREIGN KEY([ID_Airport])
REFERENCES [dbo].[Airports] ([ID_Airport])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Aircraft] CHECK CONSTRAINT [FK_Aircraft_Airports]
GO
ALTER TABLE [dbo].[LogBook]  WITH CHECK ADD  CONSTRAINT [FK_LogBook_Aircraft] FOREIGN KEY([RegistrationNumber])
REFERENCES [dbo].[Aircraft] ([RegistrationNumber])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LogBook] CHECK CONSTRAINT [FK_LogBook_Aircraft]
GO
ALTER TABLE [dbo].[LogBook]  WITH CHECK ADD  CONSTRAINT [FK_LogBook_Airports_FROM] FOREIGN KEY([ID_Airport_FROM])
REFERENCES [dbo].[Airports] ([ID_Airport])
GO
ALTER TABLE [dbo].[LogBook] CHECK CONSTRAINT [FK_LogBook_Airports_FROM]
GO
ALTER TABLE [dbo].[LogBook]  WITH CHECK ADD  CONSTRAINT [FK_LogBook_Airports_TO] FOREIGN KEY([ID_Airport_TO])
REFERENCES [dbo].[Airports] ([ID_Airport])
GO
ALTER TABLE [dbo].[LogBook] CHECK CONSTRAINT [FK_LogBook_Airports_TO]
GO
ALTER TABLE [dbo].[RotablePartsAircraft]  WITH CHECK ADD  CONSTRAINT [FK_RotablePartsAircraft_Aircraft] FOREIGN KEY([RegistrationNumber])
REFERENCES [dbo].[Aircraft] ([RegistrationNumber])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RotablePartsAircraft] CHECK CONSTRAINT [FK_RotablePartsAircraft_Aircraft]
GO
ALTER TABLE [dbo].[RotablePartsAircraft]  WITH CHECK ADD  CONSTRAINT [FK_RotablePartsAircraft_RotablePartsLog] FOREIGN KEY([ID_RotablePartsLog], [ID_RotableParts])
REFERENCES [dbo].[RotablePartsLog] ([ID_RotablePartsLog], [ID_RotableParts])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RotablePartsAircraft] CHECK CONSTRAINT [FK_RotablePartsAircraft_RotablePartsLog]
GO
ALTER TABLE [dbo].[RotablePartsLog]  WITH CHECK ADD  CONSTRAINT [FK_RotablePartsLog_RotableParts] FOREIGN KEY([ID_RotableParts])
REFERENCES [dbo].[RotableParts] ([ID_RotableParts])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RotablePartsLog] CHECK CONSTRAINT [FK_RotablePartsLog_RotableParts]
GO
ALTER TABLE [dbo].[RotablePartsService]  WITH CHECK ADD  CONSTRAINT [FK_RotablePartsService_RotablePartsLog] FOREIGN KEY([ID_RotablePartsLog], [ID_RotableParts])
REFERENCES [dbo].[RotablePartsLog] ([ID_RotablePartsLog], [ID_RotableParts])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RotablePartsService] CHECK CONSTRAINT [FK_RotablePartsService_RotablePartsLog]
GO
ALTER TABLE [dbo].[RotablePartsStock]  WITH CHECK ADD  CONSTRAINT [FK_RotablePartsStock_Aircraft] FOREIGN KEY([RegistrationNumber])
REFERENCES [dbo].[Aircraft] ([RegistrationNumber])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RotablePartsStock] CHECK CONSTRAINT [FK_RotablePartsStock_Aircraft]
GO
ALTER TABLE [dbo].[RotablePartsStock]  WITH CHECK ADD  CONSTRAINT [FK_RotablePartsStock_RotablePartsLog] FOREIGN KEY([ID_RotablePartsLog], [ID_RotableParts])
REFERENCES [dbo].[RotablePartsLog] ([ID_RotablePartsLog], [ID_RotableParts])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RotablePartsStock] CHECK CONSTRAINT [FK_RotablePartsStock_RotablePartsLog]
GO
USE [master]
GO
ALTER DATABASE [DIPLOMSKI] SET  READ_WRITE 
GO
