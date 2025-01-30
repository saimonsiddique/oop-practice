from Employee import EmployeeManager
import os
from dotenv import load_dotenv
from Employee import Employee

# Load environment variables from .env file
load_dotenv()

if __name__ == "__main__":
    csv_file_path = os.getenv("CSV_FILE_PATH")

    manager = EmployeeManager()

    manager.read_from_csv(csv_file_path)

    max_salary_employee = manager.get_max_salary_employee()
    if max_salary_employee:
        print(f"Max Salary Employee: {max_salary_employee.name} with salary {max_salary_employee.salary}")
    else:
        print("No employees found.")

    min_salary_employee = manager.get_min_salary_employee()
    if min_salary_employee:
        print(f"Min Salary Employee: {min_salary_employee.name} with salary {min_salary_employee.salary}")
    else:
        print("No employees found.")
