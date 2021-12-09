USE CinemaDataBase
GO

INSERT INTO Composers(ComposerFirstName, ComposerLastName, ComposerMiddleName)
VALUES
(N'Svyatoslav','Kruchinin', 'Stanislavovich'),
(N'David','Gushin','Sergeevich'),
(N'Vladimir','Tonicoy','Vladislavovich'),
(N'Evgeniy','Shalin','Denisovich'),
(N'Kristina','Ivko','Vladimirovna')
GO

INSERT INTO Directors(DirectorFirstName, DirectorLastName, DirectorMiddleName)
VALUES
(N'Svyatoslav','Kruchinin', 'Stanislavovich'),
(N'David','Gushin','Sergeevich'),
(N'Vladimir','Tonicoy','Vladislavovich'),
(N'Evgeniy','Shalin','Denisovich'),
(N'Kristina','Ivko','Vladimirovna')
GO

SELECT * FROM Composers
GO
SELECT * FROM Directors
GO