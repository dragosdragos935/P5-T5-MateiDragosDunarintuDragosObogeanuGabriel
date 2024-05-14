-- Tabela Mesaje
CREATE TABLE Mesaje (
    MessageID INT PRIMARY KEY,
    Expeditor INT,
    Destinatar INT,
    Continut TEXT,
    DataOra DATETIME,
    Atasamente TEXT,
    FOREIGN KEY (Expeditor) REFERENCES Utilizator(UserID),
    FOREIGN KEY (Destinatar) REFERENCES Utilizator(UserID)
);
