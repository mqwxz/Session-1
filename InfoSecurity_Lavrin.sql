-- Создание таблиц

CREATE TABLE [role]
(
	role_id INT PRIMARY KEY IDENTITY NOT NULL,
	role_name NVARCHAR(16) NOT NULL
)

CREATE TABLE country 
(
	country_id INT PRIMARY KEY IDENTITY NOT NULL,
	country_ru_name NVARCHAR(100) NOT NULL,
	country_eng_name NVARCHAR(100) NOT NULL,
	country_code_char NVARCHAR(2) NOT NULL,
	country_code_int SMALLINT NOT NULL
)

CREATE TABLE direction
(
	direction_id INT PRIMARY KEY IDENTITY NOT NULL,
	direction_name NVARCHAR(32) NOT NULL
)

CREATE TABLE [event]
(
	event_id INT PRIMARY KEY IDENTITY NOT NULL,
	event_name NVARCHAR(32) NOT NULL
)

CREATE TABLE [user]
(
	user_id INT PRIMARY KEY IDENTITY NOT NULL,
	user_last_name NVARCHAR(100),
	user_first_name NVARCHAR(100),
	user_middle_name NVARCHAR(100),
	user_email NVARCHAR(100) NOT NULL,
	user_password NVARCHAR(32) NOT NULL,
	user_gender NVARCHAR(16) NOT NULL,
	user_date_of_birthday DATE,
	user_country_id INT FOREIGN KEY REFERENCES country (country_id),
	user_phone NVARCHAR(30),
	user_direction_id INT FOREIGN KEY REFERENCES direction (direction_id),
	user_event_id INT FOREIGN KEY REFERENCES [event] (event_id),
	user_photo NVARCHAR(32),
	user_role_id INT FOREIGN KEY REFERENCES [role] (role_id) NOT NULL
)

CREATE TABLE city
(
	city_id INT PRIMARY KEY IDENTITY NOT NULL,
	city_name NVARCHAR(100) NOT NULL
)


CREATE TABLE event_blockchain
(
	event_bc_id INT PRIMARY KEY IDENTITY NOT NULL,
	event_bc_name NVARCHAR(100) NOT NULL,
	event_bc_date DATE NOT NULL,
	event_bc_days TINYINT NOT NULL,
	event_bc_city_id INT FOREIGN KEY REFERENCES city (city_id) NOT NULL,
	event_user_id INT FOREIGN KEY REFERENCES [user] (user_id)
)

CREATE TABLE activity
(
	activity_id INT PRIMARY KEY IDENTITY,
	activity_name NVARCHAR(100),
	activity_day TINYINT,
	activity_time_start TIME,
	activity_user_id INT FOREIGN KEY REFERENCES [user] (user_id)
)

CREATE TABLE event_bc_activity
(
	event_bc_id INT FOREIGN KEY REFERENCES event_blockchain (event_bc_id),
	activity_id INT FOREIGN KEY REFERENCES activity (activity_id)
)

CREATE TABLE jury
(
	jury_id INT PRIMARY KEY IDENTITY NOT NULL,
	jury_name NVARCHAR(MAX) NOT NULL,
)

CREATE TABLE jury_activity
(
	jury_activity_id INT PRIMARY KEY IDENTITY NOT NULL,
	activity_id INT FOREIGN KEY REFERENCES activity (activity_id) NOT NULL,
	jury_id INT FOREIGN KEY REFERENCES jury (jury_id),
	jury_activity_user_id INT FOREIGN KEY REFERENCES  [user] (user_id)
)




-- Вставка данных

-- Роли
INSERT INTO [role]
VALUES 
('Участник'),
('Модератор'),
('Организатор'),
('Жюри'),
('Гость')

-- Страны
INSERT INTO country
SELECT *
FROM dbo.country_import

-- Направления (для user)
INSERT INTO direction
SELECT *
FROM dbo.direction_import

-- Мероприятия (для user)
INSERT INTO [event]
SELECT *
FROM dbo.event_import

-- Удаление NULL в участниках
DELETE 
FROM participant_import
WHERE [Фамилия] IS NULL

-- Участники
INSERT INTO [user] (user_last_name,
					user_first_name,
					user_middle_name,
					user_email,
					user_date_of_birthday,
					user_country_id,
					user_phone,
					user_password,
					user_photo,
					user_gender,
					user_role_id)
SELECT *
FROM dbo.participant_import

-- Модераторы
INSERT INTO [user]
SELECT Фамилия,
		Имя,
		Отчество,
		почта,
		пароль,
		пол,
		[дата рождения],
		страна,
		телефон,
		направление,
		мероприятие,
		фото,
		Роль
FROM dbo.moderator_import

-- Организаторы
INSERT INTO [user] (user_last_name,
					user_first_name,
					user_middle_name,
					user_email,
					user_date_of_birthday,
					user_country_id,
					user_phone,
					user_password,
					user_photo,
					user_gender,
					user_role_id)
SELECT *
FROM dbo.organizer_import

-- Удаление NULL в жюри
DELETE 
FROM jury_import
WHERE [Фамилия] IS NULL

-- Жюри
INSERT INTO [user] (user_last_name,
					user_first_name,
					user_middle_name,
					user_gender,
					user_email,
					user_date_of_birthday,
					user_country_id,
					user_phone,
					user_direction_id,
					user_password,
					user_photo,
					user_role_id)
SELECT *
FROM dbo.jury_import

-- Удаление NULL в городах
DELETE 
FROM city_import
WHERE Город IS NULL

-- Города
INSERT INTO city
SELECT *
FROM city_import

-- Мероприятие_блокчейн
INSERT INTO event_blockchain
SELECT * 
FROM event_blockchain_import

-- Активность
INSERT INTO activity
SELECT *
FROM activity_import

-- Жюри
INSERT INTO jury
VALUES
('Жюри 1'),
('Жюри 2'),
('Жюри 3'),
('Жюри 4'),
('Жюри 5')

-- Мероприятие-активность
INSERT INTO event_bc_activity
SELECT event_bc_id, 
       activity_id
FROM dbo.activity_event_import act
JOIN event_blockchain e_b
	ON e_b.event_bc_name = act.[Наименование мероприятия]
JOIN activity a
	ON a.activity_name = act.Активность

-- Временная таблица (5 insert'ов)
CREATE TABLE #temp_activity
(activity_id INT,
 user_id INT
)

INSERT INTO #temp_activity

SELECT activity_id, user_id
FROM activity a
JOIN Active act
    ON act.Активность = a.activity_name
LEFT JOIN [user] u
    ON (u.user_last_name + ' ' + u.user_first_name + ' ' + u.user_middle_name)  = [Жюри 1] 

-- Жюри (активность)
INSERT INTO jury_activity (activity_id, jury_activity_user_id)
SELECT *
FROM #temp_activity
ORDER BY activity_id
