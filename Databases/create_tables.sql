-- Verifică dacă tabela Users există deja
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users')
BEGIN
    -- Tabela pentru utilizatori
    CREATE TABLE Users (
        UserId INT PRIMARY KEY IDENTITY(1,1),
        Username NVARCHAR(50) NOT NULL UNIQUE,
        PasswordHash NVARCHAR(100) NOT NULL,
        Email NVARCHAR(100) NOT NULL UNIQUE,
        FullName NVARCHAR(100)
    );
END;

-- Verifică dacă tabela Logins există deja
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Logins')
BEGIN
    -- Tabela pentru autentificare
    CREATE TABLE Logins (
        LoginId INT PRIMARY KEY IDENTITY(1,1),
        UserId INT NOT NULL,
        LoginTime DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (UserId) REFERENCES Users(UserId)
    );
END;

-- Verifică dacă tabela Registrations există deja
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Registrations')
BEGIN
    -- Tabela pentru înregistrare
    CREATE TABLE Registrations (
        RegistrationId INT PRIMARY KEY IDENTITY(1,1),
        UserId INT NOT NULL,
        RegistrationTime DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (UserId) REFERENCES Users(UserId)
    );
END;
