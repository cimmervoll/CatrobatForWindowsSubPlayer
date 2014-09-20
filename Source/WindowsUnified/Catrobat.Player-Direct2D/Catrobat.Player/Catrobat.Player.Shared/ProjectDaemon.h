#pragma once

#include "Project.h"
#include "XMLParser.h"

#include <vector>

class ProjectDaemon
{
public:
	static ProjectDaemon *Instance();
    
    void ReInit();
	void SetProject(Project *project);
	Project *GetProject();
	std::string GetProjectPath();
	std::vector<Platform::String ^> *GetProjectList();
	std::vector<Platform::String ^> *GetFileList();

	Concurrency::task<bool> OpenProject(Platform::String^ projectName);
	void ApplyDesiredRenderTargetSizeFromProject();

    void AddDebug(Platform::String^ info);
	std::vector<std::string> *GetErrorList();

private:
	ProjectDaemon();
	ProjectDaemon(ProjectDaemon const&);            
    ProjectDaemon& operator=(ProjectDaemon const&); 
	~ProjectDaemon();

	static ProjectDaemon *m_instance;

	Project *m_project;
	std::string m_projectPath;
	std::vector<Platform::String ^> *m_projectList;
	std::vector<Platform::String ^> *m_files;
	Platform::String^ m_currentFolder;

	ID3D11Device1 *m_device;

	std::vector<std::string> *m_errorList;
};
