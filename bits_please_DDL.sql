create table business (
	id 				varchar(60) primary key,
	address 		varchar(60) not null,
	name 			varchar(30) not null,
	state 			char(2) not null,
	city 			char(24) not null,
	longitude 		double not null,
	latitude 		double not null,
	open 			boolean not null,
	review_count 	int not null,
	type 			char(30) not null
);

create table attributes (
	business_id 	varchar(60) references business(id),
	delivery 		boolean not null,
	take_out 		boolean not null,
	drive_thru 		boolean not null,
	dessert 		boolean not null,
	late_night 		boolean not null,
	lunch 			boolean not null,
	dinner 			boolean not null,
	brunch 			boolean not null,
	breakfast 		boolean not null,
	caters			boolean not null,
	noise_level 	char(10) not null,
	reservations 	boolean not null,
	romantic 		boolean not null,
	intimate 		boolean not null,
	classy 			boolean not null,
	hipster 		boolean not null,
	divey 			boolean not null,
	touristy 		boolean not null,
	trendy 			boolean not null,
	upscale 		boolean not null,
	casual 			boolean not null,
	garage 			boolean not null,
	street 			boolean not null,
	validated 		boolean not null,
	lot 			boolean not null,
	valet 			boolean not null,
	tv 				boolean not null,
	outdoor_seating boolean not null,
	attire 			char(20) not null,
	alcohol 		char(20) not null, 
	waiter_service 	boolean not null,
	accepts_CC 		boolean not null,
	good_for_kids 	boolean not null,
	good_for_groups boolean not null,
	price_range 	int not null
 );

create table user (
	id int primary key
);

create table neighborhood (
	business_id varchar(60) references business(id),
	name 		varchar(40) not null
);

create table hours (
	business_id varchar(60) references business(id),
	day 		char(10) not null,
	open 		time not null,
	close 		time not null
);

create table categories (
	business_id varchar(60) references business(id),
	category 	char(24) not null
);

create table review (
	business_id varchar(60) references business(id),
	user_id 	int references user(id),
	cool		int default 0,
	type		char(20) not null,
	funny		int default 0,
	text		varchar(200),
	id			int primary key,
	stars		int default 0,
	date		datetime not null,
	useful		int default 0
);