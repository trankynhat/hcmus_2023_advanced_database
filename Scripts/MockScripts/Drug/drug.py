import random
import json
import pyodbc
from tqdm import tqdm

with open("MockScripts/Drug/meds.json", 'r') as file:
    data = json.load(file)
    file.close()

_data = []

for _, l in data.items():
    for _v in l:
        _data.append(
            {
                "name":_v["commercial_name"],
                "dci": _v["dci"]
            }
        )


_data1 = _data[:5000]
_data2 = _data[-151:]

conn = pyodbc.connect("DRIVER={ODBC Driver 17 for SQL Server};SERVER=REVISION-PC;DATABASE=CQ_CSDLNC_05;Trusted_connection=yes")
conn.autocommit = True

sql_stmts = []
for _1 in _data1:
    for _2 in _data2:
        name = _1["name"] + " " + _2["name"]
        dci = _1["dci"] + _2["dci"]
        c = random.choice(["c1", "c2", "c3", "c4"])
        sql_stmt = f"INSERT INTO drug(code, name, description, price_unit, price_per_unit) VALUES('{dci}', '{name}', '{name}', '{c}', {random.randint(1000, 1_000_000)})"
        sql_stmts.append(sql_stmt)

for stmt in tqdm(sql_stmts):
    try:
        conn.execute(stmt)
    except Exception as e:
        continue
