drop trigger tStars;
create trigger tStars after insert on review
for each row
	update business set review_count=(select count(*) from review), stars=(select avg(stars) from review) where id=NEW.business_id;  
