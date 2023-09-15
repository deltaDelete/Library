create table genders (
    gender_id int auto_increment primary key,
    name varchar(255) charset utf8 not null
);

create table clients
(
    client_id  int auto_increment
        primary key,
    last_name  varchar(255) charset utf8 not null,
    first_name varchar(255) charset utf8 not null,
    gender_id int not null,
    constraint gender_fk 
        foreign key (gender_id) references genders(gender_id)
);

create table books (
    book_id int auto_increment primary key,
    title nvarchar(255) not null,
    author nvarchar(255) not null,
    year int not null,
    publisher nvarchar(255) not null
);

create table booked_books (
    id int auto_increment primary key,
    book_id int not null,
    client_id int not null,
    date datetime not null default now(),
    days int not null default 7,
    constraint book_fk
        foreign key (book_id) references books (book_id),
    constraint client_fk
        foreign key (client_id) references clients (client_id)
)