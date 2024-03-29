# CLI_OS - Educational Operating System

## Overview

Welcome to CLI_OS, an educational operating system designed to showcase understanding in the course subject of Operating Systems. This project serves as a learning tool to demonstrate fundamental concepts and principles of operating systems in a command-line interface environment.

## Features

- **Command-Line Interface:** Provides a minimalistic command-line interface for interaction.
- **Basic System Calls:** Implements essential system calls to showcase core operating system functionality.
- **Educational Purpose:** Designed with clarity to aid learning about operating system concepts.
- **Modular Architecture:** Organized codebase with clear modules for easy comprehension.

## How to Use

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/BertDrei/CLI_OS.git
2. **Install QEMU:**
   - Follow the instructions on the QEMU website to install the virtual machine emulator:
     [QEMU Installation](https://www.qemu.org/download/)
3. **Run CLI_OS:**
   - Navigate to the project directory.
   - Use QEMU to run the operating system:
     ```bash
     qemu-system-x86_64 -cdrom **os_name**.iso
     ```
4. **Explore and Learn:**
   - Interact with the CLI_OS environment to explore the implemented operating system functionalities.
   - Refer to the source code and documentation for a deeper understanding of the concepts demonstrated.

## Documentation

Commands:
help - show all commands.

cd - set directory

mkfile - make a new file

mkdir - make a new directory

delfile - delete file

deldir - delete directory

about - show version and some infoemation about os

time - shows time and date

bsod - makes a Black Screen OF DEATH

dir - shows directory

readfile - read the file

editfile - edit file

rewritefile - rewriting the file

runfile - runs a file
