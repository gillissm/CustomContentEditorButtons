# CustomContentEditorButtons
The Code Attic-Custom Content Editor Buttons, adds two new buttons to the developer tab of the ribbon. The first button is called 'Collapse All Sections', when clicked all field sections currently in the window will be collapsed to the header. The second new button is 'Expand All Sections', performs the opposite action by expanding all field sections in the current window.

To support these actions the following items are installed:

Sitecore Artifacts, all stored in the Core DB 
* Core DB -> Sitecore -> content -> Applications ->Content Editor -> Ribbons -> Chunks -> Accordon Section Chunk
* Core DB -> Sitecore -> content -> Applications ->Content Editor -> Ribbons -> Chunks -> Accordon Section Chunk -> Collapse All
* Core DB -> Sitecore -> content -> Applications ->Content Editor -> Ribbons -> Chunks -> Accordon Section Chunk -> Expand All
* Core DB -> Sitecore -> content -> Applications ->Content Editor -> Ribbons -> Strips -> Developer -> Accordon Section

File System 
* Web root -> App_Config -> Include -> zzTheCodeAttic -> TheCodeAttic.ContentEditorInjectPipeline.config
* Web root -> App_Config -> Include -> zzTheCodeAttic -> TheCodeAttic.CustomContentEditorCommands.config
* Web root -> bin -> TheCodeAttic.CustomContentEditorButtons.dll
* Web root -> sitecore modules -> Shell -> TheCodeAttic -> TheCodeAttic.CollapseExpandCommands.js
