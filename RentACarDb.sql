INSERT INTO Cars(CarId,BrandId,ColorId,ModelYear,DailyPrice,Description)
VALUES
(1,2,1,2012,15000,'Manuel Benzin'),
(2,3,1,2015,11000,'Otomatik Dizel'),
(3,1,2,2017,12000,'Manuel Dizel'),
(4,2,1,2009,90000,'Manuel Benzin');

INSERT INTO Colors(ColorName)
VALUES
('Beyaz'),
('Siyah'),
('Mavi');

INSERT INTO Brands(BrandName)
VALUES
('Mercedes'),
('BMW'),
('Fiat');

SELECT * FROM Cars
SELECT * FROM Brands
SELECT * FROM Colors

