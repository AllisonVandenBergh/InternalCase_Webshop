#!/bin/bash
docker start webshop-database

current_folder=$(pwd)

osascript <<END
tell application "iTerm"
    activate
    set newWindow to (create window with default profile)
    tell current session of newWindow
        write text "dotnet run watch --project ${current_folder}/webshop-api/Api --launch-profile https"
    end tell
    tell current session of newWindow
        select
        set newTab to (split horizontally with default profile)
        tell newTab
            write text "cd ${current_folder}/webshop-web && pnpm run dev"
        end tell
    end tell
end tell
END
