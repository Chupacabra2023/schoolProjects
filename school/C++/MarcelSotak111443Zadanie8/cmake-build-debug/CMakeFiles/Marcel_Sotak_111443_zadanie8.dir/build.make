# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.17

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Disable VCS-based implicit rules.
% : %,v


# Disable VCS-based implicit rules.
% : RCS/%


# Disable VCS-based implicit rules.
% : RCS/%,v


# Disable VCS-based implicit rules.
% : SCCS/s.%


# Disable VCS-based implicit rules.
% : s.%


.SUFFIXES: .hpux_make_needs_suffix_list


# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "C:\Program Files\JetBrains\CLion 2020.3.2\bin\cmake\win\bin\cmake.exe"

# The command to remove a file.
RM = "C:\Program Files\JetBrains\CLion 2020.3.2\bin\cmake\win\bin\cmake.exe" -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/flags.make

CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.obj: CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/flags.make
CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.obj: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.obj"
	C:\MinGW\bin\g++.exe  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles\Marcel_Sotak_111443_zadanie8.dir\main.cpp.obj -c C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\main.cpp

CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.i"
	C:\MinGW\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\main.cpp > CMakeFiles\Marcel_Sotak_111443_zadanie8.dir\main.cpp.i

CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.s"
	C:\MinGW\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\main.cpp -o CMakeFiles\Marcel_Sotak_111443_zadanie8.dir\main.cpp.s

# Object files for target Marcel_Sotak_111443_zadanie8
Marcel_Sotak_111443_zadanie8_OBJECTS = \
"CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.obj"

# External object files for target Marcel_Sotak_111443_zadanie8
Marcel_Sotak_111443_zadanie8_EXTERNAL_OBJECTS =

Marcel_Sotak_111443_zadanie8.exe: CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/main.cpp.obj
Marcel_Sotak_111443_zadanie8.exe: CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/build.make
Marcel_Sotak_111443_zadanie8.exe: CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/linklibs.rsp
Marcel_Sotak_111443_zadanie8.exe: CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/objects1.rsp
Marcel_Sotak_111443_zadanie8.exe: CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable Marcel_Sotak_111443_zadanie8.exe"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\Marcel_Sotak_111443_zadanie8.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/build: Marcel_Sotak_111443_zadanie8.exe

.PHONY : CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/build

CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles\Marcel_Sotak_111443_zadanie8.dir\cmake_clean.cmake
.PHONY : CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/clean

CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8 C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8 C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\cmake-build-debug C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\cmake-build-debug C:\Users\marma\CLionProjects\prog2\Marcel_Sotak_111443_zadanie8\cmake-build-debug\CMakeFiles\Marcel_Sotak_111443_zadanie8.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/Marcel_Sotak_111443_zadanie8.dir/depend
