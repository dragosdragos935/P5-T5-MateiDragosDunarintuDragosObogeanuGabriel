-- Tabela Tranzacție
CREATE TABLE Tranzactie (
    TransactionID INT PRIMARY KEY,
    AccountID INT,
    Tip VARCHAR(10),
    Suma DECIMAL(10, 2),
    DataOra DATETIME,
    FOREIGN KEY (AccountID) REFERENCES Cont(AccountID)
);
