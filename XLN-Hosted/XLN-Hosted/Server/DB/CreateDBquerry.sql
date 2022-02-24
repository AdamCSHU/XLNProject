-- SQLite
CREATE TABLE User(
    user_id INTEGER PRIMARY KEY AUTOINCREMENT,
    password TEXT NOT NULL
    email TEXT NOT NULL,
    phone TEXT NULL,
    username TEXT NULL,
    address TEXT NULL
);

CREATE TABLE Tickets(
    ticket_id INTEGER PRIMARY KEY AUTOINCREMENT,
    user_id INTEGER NOT NULL,
    title TEXT NOT NULL,
    description TEXT NOT NULL,
    status INT DEFAULT 1,
    image_url TEXT NULL,
    FOREIGN KEY(user_id) REFERENCES User(user_id)
);

INSERT INTO User(user_id,email,password,phone,username,address)
VALUES
(1,'some.guy@gmail.com','password','12345678','Some Guy', NULL),
(2,'this.guy@gmail.com','password2','12345678','This Guy', NULL),
(3,'that.guy@gmail.com','password3','12345678','That Guy', NULL);