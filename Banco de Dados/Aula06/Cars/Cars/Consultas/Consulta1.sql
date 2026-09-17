USE Automoveis;
GO

-- Atualiza somente a coluna Foto dos carros (Tipo = 1).
DECLARE @PastaCarros nvarchar(4000) = N'C:\Users\Back\Documents\DEVBACKEND\Banco de Dados\Aula06\Cars\Cars\Fotos\Carros\';

UPDATE estoque
SET Foto = @PastaCarros + fotos.NomeArquivo
FROM dbo.Estoque AS estoque
INNER JOIN (VALUES
	(1, N'Carro1.jpg'),
	(2, N'Carro2.jpg'),
	(6, N'Carro3.jpg'),
	(7, N'Carro4.jpg'),
	(9, N'Carro5.jpg'),
	(10, N'Carro6.jpg'),
	(16, N'Carro7.jpg'),
	(17, N'Carro8.jpg'),
	(18, N'Carro9.jpg'),
	(19, N'Carro10.jpg'),
	(20, N'Carro11.jpg'),
	(21, N'Carro12.jpg'),
	(22, N'Carro13.jpg'),
	(23, N'Carro14.jpg'),
	(24, N'Carro15.jpg'),
	(26, N'Carro16.jpg'),
	(33, N'Carro17.jpg'),
	(34, N'Carro18.jpg')
) AS fotos(Id, NomeArquivo) ON fotos.Id = estoque.Id
WHERE estoque.Tipo = 1;
GO

-- Atualiza somente a coluna Foto das motos (Tipo = 2).
DECLARE @PastaMotos nvarchar(4000) = N'C:\Users\Back\Documents\DEVBACKEND\Banco de Dados\Aula06\Cars\Cars\Fotos\Motos\';

UPDATE estoque
SET Foto = @PastaMotos + fotos.NomeArquivo
FROM dbo.Estoque AS estoque
INNER JOIN (VALUES
	(3, N'Moto1.jpg'),
	(4, N'Moto2.jpg'),
	(5, N'Moto3.jpg'),
	(8, N'Moto4.jpg'),
	(11, N'Moto5.jpg'),
	(12, N'Moto6.jpg'),
	(13, N'Moto7.jpg'),
	(14, N'Moto8.jpg'),
	(15, N'Moto9.jpg'),
	(25, N'Moto10.jpg'),
	(27, N'Moto11.jpg'),
	(28, N'Moto12.jpg'),
	(29, N'Moto13.jpg'),
	(30, N'Moto14.jpg'),
	(31, N'Moto15.jpg'),
	(32, N'Moto16.jpg'),
	(35, N'Moto17.jpg'),
	(36, N'Moto18.jpg')
) AS fotos(Id, NomeArquivo) ON fotos.Id = estoque.Id
WHERE estoque.Tipo = 2;
GO
