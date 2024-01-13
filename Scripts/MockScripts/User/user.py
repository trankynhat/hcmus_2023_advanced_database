import random
from datetime import datetime
from faker import Faker
from tqdm import tqdm
import math

fake = Faker()

# insert into user (id, username, password, full_name, date_of_birth, phone_number, email, permanent_address, gender, working_branch_id) values (1, 'lheliot0', 'password', 'Luelle Heliot', '04/25/1969', '3469483365', 'lheliot0@ebay.com', '212 North Place', 0, 733)
file_path = "MockScripts/User/user.txt"

usernames = [0]

with open(file_path, 'w') as file:
    for i in tqdm(range(150_000)):
        name = fake.name()
        username = "_".join(name.lower().split(" "))

        while username in usernames:
            name = fake.name()
            username = "_".join(name.lower().split(" "))
            usernames.append(username)

        file.write(f"insert into [user] ( username, password, full_name, date_of_birth, phone_number, email, permanent_address, gender, working_branch_id) values ( '{username}', 'password', '{name}', '{
                   fake.date_between(start_date=datetime(1950, 1, 1).date(), end_date='+60y')}', '{fake.phone_number()}', '{username}@gmail.com', '{fake.address()}', {random.randint(0, 1)}, {math.ceil((i+1)/150)})\n")
