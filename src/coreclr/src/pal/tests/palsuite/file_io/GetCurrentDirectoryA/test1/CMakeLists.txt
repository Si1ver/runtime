set(SOURCES
  GetCurrentDirectoryA.cpp
)

add_executable(paltest_getcurrentdirectorya_test1
  ${SOURCES}
)

add_dependencies(paltest_getcurrentdirectorya_test1 coreclrpal)

target_link_libraries(paltest_getcurrentdirectorya_test1
  ${COMMON_TEST_LIBRARIES}
)
