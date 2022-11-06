CREATE TABLE [dbo].[FormasDePago] (
    [IdFormaPago]          INT          IDENTITY (1, 1) NOT NULL,
    [DescripcionFormaPago] VARCHAR (60) NOT NULL,
    CONSTRAINT [PK_FormasDePago] PRIMARY KEY CLUSTERED ([IdFormaPago] ASC)
);



