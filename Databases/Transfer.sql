
-- Tabela Transfer
CREATE TABLE Transfer (
    TransferID INT PRIMARY KEY,
    ContSursaID INT,
    ContDestinatieID INT,
    Suma DECIMAL(10, 2),
    DataOra DATETIME,
    Status VARCHAR(10),
    FOREIGN KEY (ContSursaID) REFERENCES Cont(AccountID),
    FOREIGN KEY (ContDestinatieID) REFERENCES Cont(AccountID)
);