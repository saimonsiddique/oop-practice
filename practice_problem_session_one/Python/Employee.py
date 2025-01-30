import csv

class Employee:
    def __init__(self, name=None, salary=0.0):
        self.name = name
        self.salary = salary

class EmployeeManager:
    def __init__(self):
        self.employees = []

    def add_employee(self, name, salary):
        self.employees.append(Employee(name, salary))

    def read_from_csv(self, file_path):
        try:
            with open(file_path, mode='r') as file:
                csv_reader = csv.reader(file)
                for row in csv_reader:
                    name, salary = row[0], float(row[1])
                    self.add_employee(name, salary)
        except FileNotFoundError:
            print("File not found!")

    def get_max_salary_employee(self):
        if not self.employees:
            return None
        max_salary_employee = self.employees[0]
        for employee in self.employees:
            if employee.salary > max_salary_employee.salary:
                max_salary_employee = employee
        return max_salary_employee

    def get_min_salary_employee(self):
        if not self.employees:
            return None
        min_salary_employee = self.employees[0]
        for employee in self.employees:
            if employee.salary < min_salary_employee.salary:
                min_salary_employee = employee
        return min_salary_employee
