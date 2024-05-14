-- Tabela Extrase
CREATE TABLE Extrase (
    StatementID INT PRIMARY KEY,
    UserID INT,
    Perioada VARCHAR(100),
    Continut TEXT,
    FOREIGN KEY (UserID) REFERENCES Utilizator(UserID)
);

