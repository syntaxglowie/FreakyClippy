import os
import re

# Directory containing files
directory = os.getcwd()

# List all files in the directory
files = os.listdir(directory)

# Extract numeric values from filenames and store with original names
file_data = []
for f in files:
    match = re.search(r'(\d+)', f)  # Find first number in filename
    if match:
        num = int(match.group())  # Convert extracted number to integer
        file_data.append((num, f))

# Sort files numerically based on extracted numbers
file_data.sort(key=lambda x: x[0])

# Rename files sequentially starting from 0
for index, (_, filename) in enumerate(file_data):
    file_extension = os.path.splitext(filename)[1]  # Keep original extension
    new_name = f"{index}{file_extension}"  # Rename as 0, 1, 2, etc.
    old_path = os.path.join(directory, filename)
    new_path = os.path.join(directory, new_name)

    print(f"Renaming: {filename} -> {new_name}")  # Debugging output

    os.rename(old_path, new_path)

print("Renaming completed.")
