drop trigger tStars;
create trigger tStars after insert on review
for each row
	update business set review_count=(select count(*) from review), stars=(select avg(stars) from review) where id=NEW.business_id;  

drop trigger tReviewCount;
delimiter $$
create trigger tReviewCount before insert on review
for each row
begin
	if (not exists (select * from business where NEW.business_id=id and open=true)) then
		signal sqlstate '45000' set message_text = 'Business isn\'t open, couldn\'t insert item.';
    end if;
end $$