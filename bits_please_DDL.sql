create table business (
 id     varchar(60) primary key,
 address   varchar(200) not null,
 zipcode varchar(60) not null,
 name   varchar(60) not null,
 state    varchar(3) not null,
 city    varchar(60) not null,
 longitude   double not null,
 latitude   double not null,
 stars   double,
 open    varchar(10) not null,
 review_count  int
);

create table attributes (
 business_id  varchar(60) references business(id),
 delivery   varchar(10),
 take_out   varchar(10),
 drive_thru   varchar(10),
 dessert   varchar(10),
 late_night   varchar(10),
 lunch    varchar(10),
 dinner    varchar(10),
 brunch    varchar(10),
 breakfast   varchar(10),
 caters   varchar(10),
 noise_level  varchar(10),
 reservations  varchar(10),
 romantic   varchar(10),
 intimate   varchar(10),
 classy    varchar(10),
 hipster   varchar(10),
 divey    varchar(10),
 touristy   varchar(10),
 trendy    varchar(10),
 upscale   varchar(10),
 casual    varchar(10),
 garage    varchar(10),
 street    varchar(10),
 validated   varchar(10),
 lot    varchar(10),
 valet    varchar(10),
 tv     varchar(10),
 outdoor_seating varchar(10),
 attire    varchar(30),
 alcohol   varchar(30), 
 waiter_service  varchar(10),
 accepts_CC   varchar(10),
 good_for_kids  varchar(10),
 good_for_groups varchar(10),
 price_range  int,
 PRIMARY KEY(business_id)
 );

create table review (
 business_id varchar(60) references business(id),
 user_id  varchar(60),
 cool  int default 0,
 type  varchar(20),
 funny  int default 0,
 text  varchar(1000),
 review_id   varchar(60) primary key,
 stars  int default 0,
 date  datetime,
 useful  int default 0
);

create table user (
 user_id varchar(60) primary key,
 yelping_since datetime,
 review_count int,
 name varchar(60),
 funny int,
 useful int,
 cool int,
 fans int,
 average_stars double,
 type varchar(30)
);

create table categories (
 business_id varchar(60) references business(id),
 category  varchar(60),
 PRIMARY KEY (business_id, category)
);
