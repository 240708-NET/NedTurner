-- On the Chinook DB, practice writing queries with the following exercises

-- USE MyDatabase;
-- GO

-- BASIC CHALLENGES
-- List all customers (full name, customer id, and country) who are not in the USA

SELECT FirstName + ' ' + LastName AS 'Customer Name',CustomerId,Country FROM dbo.Customer WHERE Country != 'USA';

-- List all customers from Brazil

SELECT FirstName + ' ' + LastName AS 'Customer Name' FROM dbo.Customer WHERE Country = 'Brazil';

-- List all sales agents

SELECT FirstName + ' ' + LastName AS 'Customer Name' FROM dbo.Employee WHERE Title = 'Sales Support Agent';

-- Retrieve a list of all countries in billing addresses on invoices

SELECT DISTINCT BillingCountry FROM dbo.Invoice;

-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
    -- (challenge: find the invoice count sales total for every year using one query)

SELECT COUNT(*) AS Count, SUM(Total) AS 'Total Sales in 2009' FROM dbo.Invoice WHERE YEAR(InvoiceDate) = 2009;

SELECT YEAR(InvoiceDate) AS 'Year', COUNT(*) AS Count, SUM(Total) AS 'Total Sales' FROM dbo.Invoice GROUP BY YEAR(InvoiceDate);

-- how many line items were there for invoice #37

SELECT COUNT(*) FROM dbo.InvoiceLine WHERE InvoiceId = 37;

-- how many invoices per country? BillingCountry  # of invoices -

SELECT BillingCountry, COUNT(*) As 'Number of Invoices' 
FROM dbo.Invoice 
GROUP BY BillingCountry;

-- Retrieve the total sales per country, ordered by the highest total sales first.

SELECT BillingCountry, SUM(Total) As 'Total Sales' 
FROM dbo.Invoice 
GROUP BY BillingCountry 
ORDER BY 'Total Sales' DESC;



-- JOINS CHALLENGES
-- Every Album by Artist

SELECT Album.Title, Artist.Name
FROM dbo.Artist AS Artist
INNER JOIN dbo.Album AS Album 
ON Artist.ArtistId = Album.ArtistId
ORDER BY Artist.ArtistId;

-- All songs of the rock genre

SELECT Track.Name AS 'Rock Style Songs'
FROM Track
INNER JOIN Genre 
ON Track.GenreId = Genre.GenreId
WHERE Genre.Name = 'Rock';


SELECT Track.Name AS 'Rock Style Songs', Artist.Name
FROM Track
INNER JOIN Genre 
ON Track.GenreId = Genre.GenreId
INNER JOIN Album
ON Track.AlbumId = Album.AlbumId
INNER JOIN Artist
ON Album.ArtistId = Artist.ArtistId
WHERE Genre.Name = 'Rock'
ORDER BY Artist.Name;

-- Show all invoices of customers from brazil (mailing address not billing)
SELECT * FROM Artist
SELECT Invoice.*
FROM Invoice
INNER JOIN Customer
ON Invoice.CustomerId = Customer.CustomerId
WHERE Customer.Country = 'Brazil';

-- Show all invoices together with the name of the sales agent for each one

SELECT Employee.FirstName + ' ' + Employee.LastName AS 'Sales Rep',Invoice.*
FROM Invoice
INNER JOIN Customer
ON Invoice.CustomerId = Customer.CustomerId
INNER JOIN Employee
ON Customer.SupportRepId = Employee.EmployeeId
WHERE Employee.Title = 'Sales Support Agent';


-- Which sales agent made the most sales in 2009?

SELECT TOP 1 Employee.EmployeeId, SUM(Invoice.Total)
FROM Invoice
INNER JOIN Customer
ON Invoice.CustomerId = Customer.CustomerId
INNER JOIN Employee
ON Customer.SupportRepId = Employee.EmployeeId
WHERE Employee.Title = 'Sales Support Agent'
GROUP BY Employee.EmployeeId
ORDER BY SUM(Invoice.Total) DESC; 

-- How many customers are assigned to each sales agent?

SELECT Employee.EmployeeId, COUNT(*)
FROM Customer
INNER JOIN Employee
ON Customer.SupportRepId = Employee.EmployeeId
GROUP BY Employee.EmployeeId;


------------- Which track was purchased the most in 2010?

SELECT Track.Name, COUNT(*)
FROM InvoiceLine
INNER JOIN Track
ON InvoiceLine.TrackId = Track.TrackId
INNER JOIN Invoice
ON InvoiceLine.InvoiceId = Invoice.InvoiceId
WHERE YEAR(Invoice.InvoiceDate) = 2010
GROUP BY InvoiceLine.TrackId;

SELECT *
FROM InvoiceLine
INNER JOIN Track
ON InvoiceLine.TrackId = Track.TrackId
INNER JOIN Invoice
ON InvoiceLine.InvoiceId = Invoice.InvoiceId
WHERE YEAR(Invoice.InvoiceDate) = 2010
ORDER BY Track.TrackId;



-- Show the top three best selling artists.

SELECT TOP 3 Artist.Name, '$'+SUM(InvoiceLine.UnitPrice)
FROM InvoiceLine
INNER JOIN Track
ON InvoiceLine.TrackId = Track.TrackId
INNER JOIN Artist
ON Track.Composer = Artist.Name
GROUP BY Artist.Name
ORDER BY SUM(InvoiceLine.UnitPrice) DESC;


-- Which customers have the same initials as at least one other customer?

SELECT c1.FirstName + ' ' + c1.LastName
FROM Customer AS c1, Customer AS c2
WHERE LEFT(c1.FirstName,1) = LEFT(c2.FirstName,1)
AND LEFT(c1.LastName,1) = LEFT(c2.LastName,1)
AND c1.CustomerId <> c2.CustomerId
ORDER BY c1.LastName;










-- ADVANCED CHALLENGES
-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?

SELECT Artist.Name
FROM Artist
LEFT JOIN Album
ON Artist.ArtistId = Album.ArtistId
WHERE Album.ArtistId IS NULL;

-- 2. which artists did not record any tracks of the Latin genre?

-- 3. which video track has the longest length? (use media type table)

SELECT TOP 1 Track.Name, Artist.ArtistId, Album.Title
FROM Track
INNER JOIN MediaType
ON Track.MediaTypeId = MediaType.MediaTypeId
INNER JOIN Album
ON Track.AlbumId = Album.AlbumId
INNER JOIN Artist
ON Album.ArtistId = Artist.ArtistId
WHERE MediaType.Name LIKE 'Protected M%'
ORDER BY Track.Milliseconds DESC;

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.


-- DML exercises

-- 1. insert two new records into the employee table.

-- 2. insert two new records into the tracks table.

-- 3. update customer Aaron Mitchell's name to Robert Walter

-- 4. delete one of the employees you inserted.

-- 5. delete customer Robert Walter.
