USE SSISDB
GO

SET IDENTITY_INSERT Articles ON;

INSERT INTO Articles (ArticleId, ArticleName)
VALUES 
(1,	'How to copy a Python only if its corresponding reqs file exists in Apache ant?'),
(2,	'How to configure nginx with docker-compose?'),
(3,	'How do you pass additional props to a functional component in React?'),
(4,	'Error generating initial migration: The type or namespace name “Migrations” does not exist'),
(5,	'how can I create an interface and implement it in another package'),
(6,	'AutoCompleteStringCollection - API - problem''s'),
(7,	'Phone verification in flutter app while registering account'),
(8,	'Backspace causes entire line to clear after user input'),
(9,	'Ruby on Rails - Devise - Destroy_with_password always returns false'),
(10,'How to go back to top of Programm'),
(11,'Redirect Router with React after an HandleSubmit'),
(12,'Backtransform logdata, package and function doesnt work?');

SET IDENTITY_INSERT Articles OFF;


SET IDENTITY_INSERT Tags ON;

INSERT INTO Tags (TagId, TagName)
VALUES 
(1,	'apache'),
(2,	'ant'),
(3,	'copy'),
(4,	'build xml'),
(5,	'docker'),
(6,	'nginx'),
(7,	'docker-compose'),
(8,	'nginx-config'),
(9,	'reactjs'),
(10,'typescript'),
(11,'ef-migrations'),
(12,'java'),
(13,'oop'),
(14,'interface'),
(15,'c#'),
(16,'api'),
(17,'autocomplete'),
(18,'andriod'),
(19,'flutter'),
(20,'dart'),
(21,'php'),
(22,'terminal'),
(23,'command-line-interface'),
(24,'ruby-on-rails'),
(25,'ruby'),
(26,'device'),
(27,'python'),
(28,'javascript');

SET IDENTITY_INSERT Tags OFF;


INSERT INTO ArticleTags (ArticleId, TagId)
VALUES 
(1,	1),
(1,	2),
(1,	3),
(1,	4),
(2,	5),
(2,	6),
(2,	7),
(2,	8),
(3,	9),
(3,	10),
(4,	11),
(5,	12),
(5,	13),
(5,	14),
(6,	15),
(6,	16),
(6,	17),
(7, 18),
(7,	19),
(7,	20),
(8,	21),
(8,	22),
(8,	23),
(9,	24),
(9,	25),
(9,	26),
(10,	27),
(11,	10),
(11,	28);