--Fyll på här så att vi får en bra SQL-seed att fylla på med mock-data


--SEED AUTHORS
Insert into Authors(Firstname, Lastname, Created)
values ('Douglas', 'Adams', GetDate());

--SEED BOOKS

--SEED REVIEWS
INSERT INTO Reviews (Title, Text, UserId, Rating, IsDeleted, Created, AuthorId)
VALUES ('HEJ', 'Text Text bla bla', '32e59fb4-f5e3-43bc-8df4-202f9209d153', 4, 'false', GETDATE(), 1);

INSERT INTO Reviews (Title, Text, UserId, Rating, IsDeleted, Created, AuthorId)
VALUES ('HEJ', 'Text Text bla bla', '32e59fb4-f5e3-43bc-8df4-202f9209d153', 2, 0, GETDATE(), 1);


--SELECT-SHORTCUTS
Select * 
FROM REVIEWS;