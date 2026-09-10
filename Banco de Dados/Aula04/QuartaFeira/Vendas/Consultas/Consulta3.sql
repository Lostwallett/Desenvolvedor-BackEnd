-- 1. Seleciona todas as colunas através do * da tabela Vendas
SELECT * FROM Vendas;
GO
-- 2. Seleciona apenas a coluna faturamento da tabela Vendas com vendas maior que 100.00
SELECT * FROM Vendas WHERE Faturamento > 100.00;
GO
-- 3. Seleciona apenas as colunas Tipo e Lucro da tabela Vendas com vendas do tipo Camisa usando LIKE e %%
SELECT Tipo, Lucro FROM Vendas WHERE Tipo LIKE '%Cam%';
GO