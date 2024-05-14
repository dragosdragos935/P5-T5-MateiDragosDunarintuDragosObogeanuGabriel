-- Tabela Cont
CREATE TABLE Cont (
    AccountID INT PRIMARY KEY,
    UserID INT,
    Sold DECIMAL(10, 2),
    AlteDetalii TEXT,
    FOREIGN KEY (UserID) REFERENCES Utilizator(UserID)
);
