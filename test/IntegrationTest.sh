#!/bin/bash
set -e

result=$(curl -X GET 'http://localhost:50000/api/Message' -H 'accept: application/json' --silent)
echo $result
if [ "$result" == '[{"text":"Welcome to chat!","user":"system","creationTime":"1900-01-01T00:00:00"}]' ]
 then
	echo "passed"
	exit 0
else
	echo "failed"
	exit 1
fi
