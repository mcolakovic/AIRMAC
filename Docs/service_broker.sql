EXEC sp_configure 'show advanced options' , '1';
GO
RECONFIGURE;
GO
EXEC sp_configure 'clr enabled' , '1';
GO
RECONFIGURE;
GO
ALTER DATABASE AIRMAC SET ENABLE_BROKER;
USE AIRMAC;
CREATE QUEUE airmac_queue;
GO
CREATE SERVICE airmac_service ON QUEUE airmac_queue
(
	[http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]
);
GO
CREATE LOGIN airmac WITH PASSWORD = 'infomont';
CREATE USER airmac FROM LOGIN airmac;
CREATE SCHEMA airmac_schema AUTHORIZATION airmac;
GO
ALTER USER airmac WITH DEFAULT_SCHEMA = airmac_schema;
GO
EXEC sp_addrolemember 'db_datareader', 'airmac';
GO
GRANT SELECT ON dbo.LogBook TO airmac;
GRANT REFERENCES ON CONTRACT::[http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification] TO airmac;
GRANT SUBSCRIBE QUERY NOTIFICATIONS TO airmac;
GRANT RECEIVE ON QueryNotificationErrorsQueue TO airmac;
GRANT SEND ON SERVICE::airmac_service  to airmac;
GRANT CREATE PROCEDURE TO airmac;
GRANT CREATE QUEUE TO airmac;
GRANT CREATE SERVICE TO airmac;
ALTER DATABASE AIRMAC SET TRUSTWORTHY ON;