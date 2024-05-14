-- Tabela Document
CREATE TABLE Document (
    DocumentID INT PRIMARY KEY,
    UserID INT,
    Tip VARCHAR(10),
    Continut TEXT,
    DataIncarcarii DATETIME,
    FOREIGN KEY (UserID) REFERENCES Utilizator(UserID)
);
