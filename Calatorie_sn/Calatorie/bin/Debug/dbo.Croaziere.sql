CREATE TABLE [dbo].[Croaziere] (
    [ID_Croaziere]  INT          IDENTITY (1, 1) NOT NULL,
    [Tip_Croaziere] INT          NULL,
    [Lista_Porturi] VARCHAR (50) NULL,
    [Data_Start]    DATE         NULL,
    [Data_Stop]     DATE         NULL,
    [Pret]          INT          NULL,
    [Nr_Pasageri]   INT          NULL,
    PRIMARY KEY CLUSTERED ([ID_Croaziere] ASC)
);
