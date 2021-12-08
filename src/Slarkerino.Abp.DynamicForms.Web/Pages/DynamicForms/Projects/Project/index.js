$(function () {

    var l = abp.localization.getResource('DynamicForms');

    var service = slarkerino.abp.dynamicForms.projects.project;
    var createModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Projects/Project/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Projects/Project/EditModal');

    var dataTable = $('#ProjectTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('DynamicForms.Project.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('DynamicForms.Project.Delete'),
                                confirmMessage: function (data) {
                                    return l('ProjectDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('ProjectTitle'),
                data: "title"
            },
            {
                title: l('ProjectResponseCount'),
                data: "responseCount"
            },
            {
                title: l('ProjectProjectType'),
                data: "projectType"
            },
            {
                title: l('ProjectProjectStatus'),
                data: "projectStatus"
            },
            {
                title: l('ProjectTags'),
                data: "tags"
            },
            {
                title: l('ProjectQuestions'),
                data: "questions"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewProjectButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
