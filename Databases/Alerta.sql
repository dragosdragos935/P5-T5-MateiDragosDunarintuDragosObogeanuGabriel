-- Tabela Alertă
CREATE TABLE Alerta (
    AlertID INT PRIMARY KEY,
    UserID INT,
    Tip VARCHAR(100),
    Parametri TEXT,
    Status VARCHAR(10),
    FOREIGN KEY (UserID) REFERENCES Utilizator(UserID)
);
