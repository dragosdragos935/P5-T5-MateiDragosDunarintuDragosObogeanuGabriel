-- Tabela Factură
CREATE TABLE Factura (
    InvoiceID INT PRIMARY KEY,
    UserID INT,
    Suma DECIMAL(10, 2),
    DataEmiterii DATE,
    Status VARCHAR(10),
    FOREIGN KEY (UserID) REFERENCES Utilizator(UserID)
);
