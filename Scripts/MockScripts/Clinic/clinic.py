import random

file_path = "MockScripts/Clinic/clinic.txt"
ri = 0
with open(file_path, 'w') as file:
    for i in range(1000):
        for j in range(10):
            ri += 1
            file.write(f"insert into clinic(clinic_id, branch_id, clinic_number) values({ri}, {i+1}, {j+1})\n")