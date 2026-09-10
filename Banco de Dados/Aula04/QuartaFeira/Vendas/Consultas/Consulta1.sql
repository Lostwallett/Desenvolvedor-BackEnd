-- Comando para criar tabela e colunas
CREATE table Vendas1 (
Id int primary key,
DataCompra nvarchar(10),
Tipo nvarchar(25),
Marca nvarchar(25),
Faturamento decimal(5,2),
Lucro decimal(5,2)
);
GO