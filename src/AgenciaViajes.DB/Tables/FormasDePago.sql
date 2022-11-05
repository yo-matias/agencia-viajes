CREATE TABLE [dbo].[FormasDePago] (
    [IdFormaPago]          INT          NOT NULL,
    [DescripcionFormaPago] VARCHAR (60) NULL,
    CONSTRAINT [PK_FormasDePago] PRIMARY KEY CLUSTERED ([IdFormaPago] ASC)
);

