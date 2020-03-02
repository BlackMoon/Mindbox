USE [SSISDB]
GO

SET IDENTITY_INSERT Articles ON;

INSERT INTO Articles(ArticleId, ArticleName)
VALUES
    (1, 'Delphi Source Code with LineFeeds Only vs CR & LF Causing Source Corruption in IDE'),
    (2, 'What exactly is Parent in getView() method'),
    (3, 'Install fabcar chaincode in hyperledger fabric'),
    (4, 'Spinnaker - Healthcheck fails though the application runs without any issues'),
    (5, 'Changing time column to POSIXct without a date value'),
    (6, 'Axios - Request failed with status code 400 error'),
    (7, 'Upgrade Symfony to 5.0 version'),
    (8, 'Check available storage when downloading file via unity web request on iOS and Android'),
    (9, 'How to get last record from table SQLite'),
    (10, 'How to pass a custom script to ./configure to be run after the compiling?'),
    (11, 'How to rotate an array right(clockwise)');

SET IDENTITY_INSERT Articles OFF;

GO

SET IDENTITY_INSERT Tags ON;

INSERT INTO Tags(TagId, TagName)
VALUES
    (1, 'delphi'),
    (2, 'ide'),
    (3, 'corruption'),
    (4, 'linefeed'),
    (5, 'android'),
    (6, 'android-studio'),
    (7, 'listview'),
    (8, 'layout-inflater'),
    (9, 'get-view'),
    (10, 'hyperledger'),
    (11, 'hyperledger-fabric'),
    (12, 'hyperledger-chaincode'),
    (13, 'chaincode'),
    (14, 'spinnaker'),
    (15, 'spinnaker-hayard'),
    (16, 'time'),
    (17, 'posixct'),
    (18, 'node.js'),
    (19, 'react-native'),
    (20, 'axios'),
    (21, 'yelp'),
    (22, 'upgrade'),
    (23, 'symyhony4'),
    (24, 'ios'),
    (25, 'unity3d'),
    (26, 'unityscript'),
    (27, 'sql'),
    (28, 'sqlite'),
    (29, 'makefile'),
    (30, 'clang'),
    (31, 'configure');

GO

SET IDENTITY_INSERT Tags OFF;

INSERT INTO ArticleTags(ArticleId, TagId)
VALUES
    (1, 1),
    (1, 2),
    (1, 3),
    (1, 4),
    (2, 5),
    (2, 6),
    (2, 7),
    (2, 8),
    (2, 9),
    (3, 10),
    (3, 11),
    (3, 12),
    (3, 13),
    (4, 14),
    (4, 15),
    (5, 16),
    (5, 17),
    (6, 18),
    (6, 19),
    (6, 20),
    (6, 21),
    (7, 22),
    (7, 23),
    (8, 5),
    (8, 24),
    (8, 25),
    (8, 26),
    (9, 5),
    (9, 27),
    (9, 28),
    (10, 29),
    (10, 30),
    (10, 31);
    
GO